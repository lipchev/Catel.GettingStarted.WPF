namespace WPF.GettingStarted.Views
{
    using Catel.Windows;

    using ViewModels;

    /// <summary>
    /// Interaction logic for FamilyWindow.xaml.
    /// </summary>
    public partial class FamilyWindow : DataWindow
    {
        private byte[] _retainedBytes = new byte[50 * 1024 * 1024];

        /// <summary>
        /// Initializes a new instance of the <see cref="FamilyWindow"/> class.
        /// </summary>
        public FamilyWindow()
            : this(null) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FamilyWindow"/> class.
        /// </summary>
        /// <param name="viewModel">The view model to inject.</param>
        /// <remarks>
        /// This constructor can be used to use view-model injection.
        /// </remarks>
        public FamilyWindow(FamilyWindowViewModel viewModel)
            : base(viewModel)
        {
            InitializeComponent();
        }
    }
}
