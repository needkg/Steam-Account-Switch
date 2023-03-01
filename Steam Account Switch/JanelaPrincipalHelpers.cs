namespace Steam_Account_Switch
{
    internal static class JanelaPrincipalHelpers
    {

        public static void AbrirFormCentralizado<T1, T2>(T1 janela1, T2 janela2) where T1 : Form where T2 : Form, new()
        {
            janela2 = new T2();

            int x = janela1.Location.X + (janela1.Width - janela2.Width) / 2;
            int y = janela1.Location.Y + (janela1.Height - janela2.Height) / 2;

            janela2.StartPosition = FormStartPosition.Manual;
            janela2.Location = new Point(x, y);

            janela2.ShowDialog(janela1);
        }
    }
}