#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Input
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class FocusManagerLostFocusEventArgs 
	{
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::System.Guid CorrelationId
		{
			get
			{
				throw new global::System.NotImplementedException("The member Guid FocusManagerLostFocusEventArgs.CorrelationId is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.DependencyObject OldFocusedElement
		{
			get
			{
				throw new global::System.NotImplementedException("The member DependencyObject FocusManagerLostFocusEventArgs.OldFocusedElement is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Input.FocusManagerLostFocusEventArgs.OldFocusedElement.get
		// Forced skipping of method Windows.UI.Xaml.Input.FocusManagerLostFocusEventArgs.CorrelationId.get
	}
}
