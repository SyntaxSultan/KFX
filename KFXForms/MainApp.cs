using DevExpress.Xpo.DB;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using KFXForms.Properties;
using DevExpress.XtraGrid;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using static DevExpress.XtraEditors.Mask.MaskSettings;

namespace KFXForms
{
    public partial class MainApp : DevExpress.XtraEditors.XtraForm
    {
        public MainApp()
        {
            InitializeComponent();

            // nazwa naszego grida 
            gridView1.FocusedRowChanged += GridView1_FocusedRowChanged;
        }

        // Metoda obsługująca zdarzenie zmiany zaznaczonego wiersza w GridView.
        private void GridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            // Pobranie aktualnie zaznaczonego wiersza jako obiekt typu CustomerClient.
            var users = gridView1.GetFocusedRow() as CustomerClient;

            // Sprawdzenie, czy obiekt nie jest null (czyli czy zaznaczony wiersz zawiera dane typu CustomerClient).
            if (users != null)
            {
                // Przypisanie wartości pola Login do kontrolki txtLogin.
                txtLogin.Text = users.Login;

                // Przypisanie wartości pola Password do kontrolki txtPassword.
                txtPassword.Text = users.Password;

                // Przypisanie wartości pola ExpiryDate do kontrolki txtExpiryDate (może być to pole edycyjne typu DataTime).
                txtExpiryDate.EditValue = users.ExpiryDate;

                // Przypisanie wartości pola Host do kontrolki txtHost.
                txtHost.Text = users.Host;

                // Przypisanie wartości pola Activate do kontrolki boolActivate (może być to pole edycyjne typu bool lub checkbox).
                boolActivate.EditValue = users.Activate;
            }
        }
        // Deklaracja zmiennej przechowującej kolekcję obiektów typu CustomerClient zarządzaną przez XPO.
        private XPCollection xpCollection;

        private void MainApp_Load(object sender, EventArgs e)
        {
            const string connectionString = "XpoProvider=MySql;server=truenas.local;user=admin;database=KFX;port=3306;password=Init1234!;";

            try
            {
                XpoDefault.DataLayer = XpoDefault.GetDataLayer(connectionString, AutoCreateOption.DatabaseAndSchema);
                // metoda która pobiere dane i przypsuje je do siatki 
                LoadData();
            }
            catch (Exception)
            {
                // Wyświetlenie okienka z informacją o błędzie połączenia z bazą danych
                XtraMessageBox.Show("Nie można połączyć się z bazą danych. Aplikacja zostanie zamknięta.", "Błąd połączenia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Zamknięcie aplikacji po naciśnięciu "OK"
                Application.Exit();
            }
        }

        public void LoadData()
        {
            // Tworzenie kolekcji obiektów typu CustomerClient
            xpCollection = new XPCollection(typeof(CustomerClient));
            // Przypisanie kolekcji jako źródła danych dla kontrolki DBVievGrid
            DBVievGrid.DataSource = xpCollection;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Pobranie loginu użytkownika

            // Wyświetlenie pytania o potwierdzenie usunięcia 
            var dlg = XtraMessageBox.Show($"Do you want to delete user <b><color=red>selected user?</color></b>", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, DevExpress.Utils.DefaultBoolean.True);

            // Sprawdzenie czy użytkownik potwierdził usunięcie
            if (dlg == DialogResult.Yes)
            {
                // Utworzenie nowego obieku do pracy z (UnitOfWork)
                using (var uow = new UnitOfWork())
                {
                    // Pobranie zaznaczonych wierszy z kontrolki GridView1 i konwersja ich na obiekty CustomerClient
                    var selectedRows = gridView1.GetSelectedRows().Select(x => gridView1.GetRow(x) as CustomerClient).ToList();
                    // Pobranie listy loginów wybranych użytkowników
                    var logins = selectedRows.Select(x => x.Login).ToList();
                    // Sprawdzenie czy loginy użytkowników są zawarte w bazie danych
                    var users = uow.Query<CustomerClient>().Where(s => logins.Contains(s.Login)).ToList();
                    // Usunięcie użytkowników z bazy danych
                    uow.Delete(users);
                    // Zatwierdzenie zmian w bazie danych
                    uow.CommitChanges();
                    // Odświeżenie danych
                    xpCollection.Reload();
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Tworzenie nowej jednostki pracy (UnitOfWork) dla zarządzania operacjami bazodanowymi.
            using (var uow = new UnitOfWork())
            {
                // Tworzenie nowego obiektu CustomerClient powiązanego z jednostką pracy.
                var users = new CustomerClient(uow);

                // Przypisanie wartości z kontrolek formularza do właściwości obiektu CustomerClient.
                users.Login = txtLogin.Text;
                users.Password = txtPassword.Text;
                users.ExpiryDate = DateTime.Parse(txtExpiryDate.EditValue.ToString());
                users.Host = txtHost.Text;
                users.Activate = (bool)boolActivate.EditValue;

                // Sprawdzenie, czy użytkownik o podanym loginie już istnieje w bazie danych.
                var isExisted = uow.Query<CustomerClient>()
                    .Where(x => x.Login == txtLogin.Text).ToList().Count > 0;

                // Jeśli użytkownik o podanym loginie już istnieje, wyświetlenie komunikatu i zakończenie metody.
                if (isExisted)
                {
                    XtraMessageBox.Show($" Save it? {users.Login}");
                    txtLogin.Focus();
                    return;
                }

                // Zatwierdzenie zmian w bazie danych.
                uow.CommitChanges();

                // Ponowne załadowanie kolekcji danych, aby uwzględnić nowo dodane zmiany.
                xpCollection.Reload();

                // Wyświetlenie komunikatu o pomyślnym zapisaniu danych.
                XtraMessageBox.Show($" Save Successful", "Message");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Pobranie loginu użytkownika
            var login = txtLogin.Text;

            // Wyświetlenie pytania o potwierdzenie aktualizacji użytkownika
            var dlg = XtraMessageBox.Show($"Do you want to update user <b><color=red>{txtLogin.Text}</color></b>", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, DevExpress.Utils.DefaultBoolean.True);

            // Sprawdzenie czy użytkownik potwierdził aktualizację
            if (dlg == DialogResult.Yes)
            {
                using (var uow = new UnitOfWork())
                {
                    // Pobranie użytkownika z bazy danych
                    var users = uow.Query<CustomerClient>().FirstOrDefault(x => x.Login == login);

                    // Sprawdzenie czy użytkownik istnieje w bazie danych
                    if (users != null)
                    {
                        // Aktualizacja danych użytkownika
                        users.Password = txtPassword.Text;
                        users.ExpiryDate = DateTime.Parse(txtExpiryDate.EditValue.ToString());
                        users.Host = txtHost.Text;
                        users.Activate = (bool)boolActivate.EditValue;

                        // Zatwierdzenie zmian w bazie danych
                        uow.CommitChanges();

                        // Ponowne załadowanie danych
                        xpCollection.Reload();

                        XtraMessageBox.Show("User updated successfully.", "Message");
                    }
                    else
                    {
                        XtraMessageBox.Show("User not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        /// <summary>
        /// Czyszczenie pól tekstowych i ustawienie wartości domyślnych dla nowego rekordu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtLogin.Text = "";
            txtPassword.Text = "";
            txtExpiryDate.Text = "";
            txtHost.Text = "";
            boolActivate.EditValue = true;
        }
    }
}
