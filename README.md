# How to use triggers in xamarin.forms listview?

This example demonstrates how to use triggers in xamarin.forms listview.

You can refer [How to use triggers in xamarin.forms listview?](https://www.syncfusion.com/kb/10020/how-to-use-triggers-in-xamarin-forms-listview) for more details

```
<syncfusion:SfListView x:Name="listView" ItemsSource="{Binding contactsinfo}" >
    <syncfusion:SfListView.ItemTemplate>
        <DataTemplate>
	    <ViewCell>
               <Label Text="{Binding ContactName}">
	         <Label.Triggers>
		    <DataTrigger TargetType="Label" Binding="{Binding Favorite}" Value="true">
		        <Setter Property="TextColor" Value="Red"/>
	            </DataTrigger>
		    <DataTrigger TargetType="Label" Binding="{Binding Favorite}" Value="false">
                        <Setter Property="TextColor" Value="Yellow"/>
	            </DataTrigger>
		  </Label.Triggers>
                </Label>
            </ViewCell>
        </DataTemplate>
    </syncfusion:SfListView.ItemTemplate>
</syncfusion:SfListView>

```
## Requirements to run the demo

* [Visual Studio 2017](https://visualstudio.microsoft.com/downloads/) or [Visual Studio for Mac](https://visualstudio.microsoft.com/vs/mac/)
* Xamarin add-ons for Visual Studio (available via the Visual Studio installer).

## Troubleshooting

### Path too long exception

If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.
