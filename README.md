# UIPlaceholder
Creating a placeholder in your app to show users that data is loading 

Here is the XAML code to create a simple UI Placeholder


# Sample building a simple UI
 
 ```
   <!--  PLACEHOLDER NO REPEAT  -->
        <Grid
            HorizontalAlignment="Center"
            VerticalAlignment="Top"
            ui:PlaceholderEx.CurrentPlaceholderState="{Binding CurrentState}">
            <ui:PlaceholderEx.PlaceholderStateItems>
                <ui:PlaceholderStateItem StateItemKey="Loading">
                    <StackPanel Orientation="Horizontal">
                        <ui:PlaceholderSkeletonView
                            Width="120"
                            Height="120"
                            Margin="20"
                            Background="#ebebeb" />
                        <StackPanel Margin="20" Orientation="Vertical">
                            <ui:PlaceholderSkeletonView
                                Width="190"
                                Height="20"
                                Margin="10"
                                Background="#ebebeb" />
                            <ui:PlaceholderSkeletonView
                                Width="150"
                                Height="20"
                                Margin="10"
                                Background="#ebebeb" />
                            <ui:PlaceholderSkeletonView
                                Width="120"
                                Height="20"
                                Margin="10"
                                Background="#ebebeb" />
                        </StackPanel>
                    </StackPanel>
                </ui:PlaceholderStateItem>
            </ui:PlaceholderEx.PlaceholderStateItems>

            <StackPanel Margin="50" Orientation="Horizontal">
                <Rectangle
                    Width="20"
                    Height="40"
                    Fill="Blue" />

                <Rectangle
                    Width="20"
                    Height="40"
                    Fill="White" />

                <Rectangle
                    Width="20"
                    Height="40"
                    Fill="Red" />
            </StackPanel>
        </Grid>
```

![alt text](/img/single.gif)


# Using the datatemplate

```
 <!--  TEMPLATE WITH REPEAT  DATATEMPLATE  -->
  <Grid
            HorizontalAlignment="Center"
            VerticalAlignment="Top"
            ui:PlaceholderEx.CurrentPlaceholderState="{Binding CurrentState}">
            <ui:PlaceholderEx.PlaceholderStateItems>
                <ui:PlaceholderStateItem RepeatItem="3" StateItemKey="Loading">
                    <ui:PlaceholderStateItem.PlaceholderTemplate>
                        <DataTemplate>
                            <StackPanel Orientation="Horizontal">
                                <ui:PlaceholderSkeletonView
                                    Width="120"
                                    Height="120"
                                    Margin="20"
                                    Background="#ebebeb" />
                                <StackPanel Margin="20" Orientation="Vertical">
                                    <ui:PlaceholderSkeletonView
                                        Width="190"
                                        Height="20"
                                        Margin="10"
                                        Background="#ebebeb" />
                                    <ui:PlaceholderSkeletonView
                                        Width="150"
                                        Height="20"
                                        Margin="10"
                                        Background="#ebebeb" />
                                    <ui:PlaceholderSkeletonView
                                        Width="120"
                                        Height="20"
                                        Margin="10"
                                        Background="#ebebeb" />
                                </StackPanel>
                            </StackPanel>
                        </DataTemplate>
                    </ui:PlaceholderStateItem.PlaceholderTemplate>

                </ui:PlaceholderStateItem>
            </ui:PlaceholderEx.PlaceholderStateItems>


            <StackPanel Margin="50" Orientation="Horizontal">
                <Rectangle
                    Width="20"
                    Height="40"
                    Fill="Blue" />

                <Rectangle
                    Width="20"
                    Height="40"
                    Fill="White" />

                <Rectangle
                    Width="20"
                    Height="40"
                    Fill="Red" />
            </StackPanel>
        </Grid>
```


![alt text](/img/datatemplate.gif)
