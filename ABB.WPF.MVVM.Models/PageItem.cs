namespace ABB.WPF.MVVM.Models
{
    public class PageItem : Base
    {
        public int PageItemId { get; set; }

        public string Name { get; set; }

        public string Type { get; set; }

        public string Parameters { get; set; }

        #region Value

        private object _Value;
        public object Value
        {
            get { return _Value; }

            set
            {
                _Value = value;

                OnPropertyChanged();
            }
        }

        #endregion

        public override string ToString() => $"{PageItemId} {Name} {Type}";

    }
}
