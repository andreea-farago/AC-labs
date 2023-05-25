namespace ACLabsApplication;

public partial class MotorValuesEntyComponent : ContentView
{
    public static readonly BindableProperty NumeProprety =
         BindableProperty.Create(nameof(NumeText),
         typeof(string),
         typeof(SetMotorValuesEntryComponent),
         defaultValue: string.Empty,
         defaultBindingMode: BindingMode.OneWay,
         propertyChanged: NumePropretyChanged);

    private static void NumePropretyChanged(BindableObject bindable, object oldValue, object newValue)
    {
        var control = (MotorValuesEntyComponent)bindable;
        control.Nume.Text = newValue?.ToString();
    }

    public string NumeText
    {
        get
        {
            return base.GetValue(NumeProprety)?.ToString();
        }
        set
        {
            base.SetValue(NumeProprety, value);
        }
    }
    public static readonly BindableProperty UnitateProprety =
       BindableProperty.Create(nameof(UnitateText),
       typeof(string),
       typeof(SetMotorValuesEntryComponent),
       defaultValue: string.Empty,
       defaultBindingMode: BindingMode.OneWay,
       propertyChanged: UnitatePropretyChanged);

    private static void UnitatePropretyChanged(BindableObject bindable, object oldValue, object newValue)
    {
        var control = (MotorValuesEntyComponent)bindable;
        control.Unitate.Text = newValue?.ToString();
    }

    public string UnitateText
    {
        get
        {
            return base.GetValue(UnitateProprety)?.ToString();
        }
        set
        {
            base.SetValue(UnitateProprety, value);
        }
    }
     
    public MotorValuesEntyComponent()
	{
		InitializeComponent();
	}
}