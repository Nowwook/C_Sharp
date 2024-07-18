using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Interactivity;
using Syncfusion.UI.Xaml.Grid;

namespace YourNamespace
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var behavior = new SfDataGrid요리행동();
            Interaction.GetBehaviors(sfDataGrid).Add(behavior);

            // Sample data for demonstration
            sfDataGrid.ItemsSource = new List<Recipe>
            {
                new Recipe { Name = "Spaghetti", Ingredients = "Pasta, Tomato Sauce, Meat" },
                new Recipe { Name = "Sushi", Ingredients = "Rice, Fish, Seaweed" },
            };
        }
    }

    public class Recipe
    {
        public string Name { get; set; }
        public string Ingredients { get; set; }
    }

    public class SfDataGrid요리행동 : Behavior<SfDataGrid>
    {
        protected override void OnAttached()
        {
            base.OnAttached();
            this.AssociatedObject.GridContextMenuOpening += 연관된개체_그리드컨텍스트메뉴열림;
        }

        protected override void OnDetaching()
        {
            base.OnDetaching();
            this.AssociatedObject.GridContextMenuOpening -= 연관된개체_그리드컨텍스트메뉴열림;
        }

        private void 연관된개체_그리드컨텍스트메뉴열림(object sender, GridContextMenuEventArgs e)
        {
            e.ContextMenu.Items.Clear();
            var 열인덱스 = this.AssociatedObject.ResolveToGridVisibleColumnIndex(e.RowColumnIndex.ColumnIndex);
            if (열인덱스 < 0 || 열인덱스 >= this.AssociatedObject.Columns.Count)
                return;
            var 열 = this.AssociatedObject.Columns[열인덱스];
            if (열 == null)
                return;

            List<object> 명령매개변수 = new List<object>();
            명령매개변수.Add(this.AssociatedObject);
            명령매개변수.Add(열);
            CommandBinding 명령바인딩 = new CommandBinding();
            this.AssociatedObject.CommandBindings.Add(명령바인딩);

            e.ContextMenu.Items.Add(new MenuItem()
            {
                Header = "요리 추가",
                Command = 요리컨텍스트메뉴명령.요리추가,
                CommandParameter = 명령매개변수
            });
        }
    }

    public static class 요리컨텍스트메뉴명령
    {
        public static readonly RoutedUICommand 요리추가 = new RoutedUICommand("요리 추가", "요리추가", typeof(요리컨텍스트메뉴명령));

        static 요리컨텍스트메뉴명령()
        {
            CommandManager.RegisterClassCommandBinding(typeof(SfDataGrid), new CommandBinding(요리추가, 요리추가_실행));
        }

        private static void 요리추가_실행(object sender, ExecutedRoutedEventArgs e)
        {
            // 요리 추가 동작을 여기에 구현합니다.
            MessageBox.Show("요리가 추가되었습니다.");
        }
    }
}
