using System;
using System.Windows.Forms;

class MyButtonClass: Form
{
    private Button mrButton;
    public MyButtonClass()   // Метод конструктора
    {
        mrButton = new Button();
        mrButton.Text = "Нажми меня";
        this.Controls.Add(mrButton);
    }
    static void Main()
    {
        Application.Run(new MyButtonClass());
    }
}