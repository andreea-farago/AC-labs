namespace ACLabsApplication;

public partial class SetMotorValuesEntryComponent : ContentView
{
    public static readonly BindableProperty NameProprety =
        BindableProperty.Create(nameof(NameText),
        typeof(string),
        typeof(SetMotorValuesEntryComponent),
        defaultValue: string.Empty,
        defaultBindingMode: BindingMode.OneWay,
        propertyChanged: NamePropretyChanged);

    private static void NamePropretyChanged(BindableObject bindable, object oldValue, object newValue)
    {
        var control = (SetMotorValuesEntryComponent)bindable;
        control.Name.Text = newValue?.ToString();
    }

    public string NameText
    {
        get
        {
            return base.GetValue(NameProprety)?.ToString();
        }
        set
        {
            base.SetValue(NameProprety, value);
        }
    }
    public static readonly BindableProperty UnitProprety =
       BindableProperty.Create(nameof(UnitText),
       typeof(string),
       typeof(SetMotorValuesEntryComponent),
       defaultValue: string.Empty,
       defaultBindingMode: BindingMode.OneWay,
       propertyChanged: UnitPropretyChanged);

    private static void UnitPropretyChanged(BindableObject bindable, object oldValue, object newValue)
    {
        var control = (SetMotorValuesEntryComponent)bindable;
        control.Unit.Text = newValue?.ToString();
    }

    public string UnitText
    {
        get
        {
            return base.GetValue(UnitProprety)?.ToString();
        }
        set
        {
            base.SetValue(UnitProprety, value);
        }
    }

   private void OnStepperValueChanged(object sender, ValueChangedEventArgs e)
    {
        double val = Convert.ToDouble(Entry.Text);
        if(e.OldValue < e.NewValue)
        {
            val++;
        }
        else
        {
            val--;
        }
        Entry.Text = val.ToString();
    }

    public SetMotorValuesEntryComponent()
    {
        InitializeComponent();
    }
}