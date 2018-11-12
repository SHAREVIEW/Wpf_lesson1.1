


DockPanel:

<Window x:Class="Wpf_lesson1._4.DockPanels"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
        xmlns:local="clr-namespace:Wpf_lesson1._4"
        mc:Ignorable="d"
        Title="DockPanels" Height="450" Width="800">
    <DockPanel Background="AliceBlue">
        <Border DockPanel.Dock="Top" Padding="5" Margin="5" 
                Background="BlueViolet" Height="45">
            <Label>1) DockPanel.Dock="Top"</Label>
        </Border>
        <Border DockPanel.Dock="Top" Padding="5" Margin="5" 
                Background="Aquamarine" Height="45" Width="450">
            <Label>2) DockPanel.Dock="Top"</Label>
        </Border>
        <Border DockPanel.Dock="Left" Padding="5" Margin="5" 
                Background="Aquamarine" Height="45" Width="450">
            <Label>3) DockPanel.Dock="Top"</Label>
        </Border>
        <Border DockPanel.Dock="Bottom" Padding="5" Margin="5" 
                Background="Aquamarine" Height="45" Width="250">
            <Label>4) DockPanel.Dock="Top"</Label>
        </Border>
        <Border Padding="5" Margin="5" Background="Aquamarine" >
            <Label Foreground="BlueViolet">5) LAST </Label>
        </Border>


    </DockPanel>



</Window>



StackPanel:

<Window x:Class="Wpf_lesson1._4.StackPanels"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
        xmlns:local="clr-namespace:Wpf_lesson1._4"
        mc:Ignorable="d"
        Title="StackPanels" Height="450" Width="800">
    <Grid>
        <StackPanel HorizontalAlignment="Left" Height="128" VerticalAlignment="Top" Width="285" Orientation="Horizontal">
            <Button Content="Button1" Height="128" VerticalAlignment="Top" Width="75"/>
            <Button Content="Button2" Height="128" VerticalAlignment="Top" Width="75"/>
            <Button Content="Button3" Height="128" VerticalAlignment="Top" Width="75"/>
        </StackPanel>
        <StackPanel HorizontalAlignment="Left" Height="128" VerticalAlignment="Top" Width="285" Margin="0,128,0,0" Orientation="Vertical">
                <Button Content="Button1" HorizontalAlignment="Left" Width="285"/>
                <Button Content="Button2" HorizontalAlignment="Left" Width="285"/>
                <Button Content="Button3" HorizontalAlignment="Left" Width="285"/>
            </StackPanel>
    </Grid>



</Window>
