   M S B A M L   `   `   `  ����  SearchAndGo%    SearchAndGo.FindAtOtherLocation   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      $��0q�5        � WindowStyle$
  None=�5       � WindowStartupLocation$ CenterScreen=�5	      $	��705��5
      $	��700��5       � 	Resources 5         ButtonStyleClose �� 
TargetType �� Property �� Value �� 
TargetType �Name J� RenderTransformOrigin'  !System.Windows.VisualStateManager	   VisualStateGroups%  System.Windows.VisualStateGroup
   Transitions%  System.Windows.VisualTransition   GeneratedDuration   States   System.Windows.VisualState   
Storyboard �� TargetProperty �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime O� Value �� EndPoint �� 
StartPoint � Color � Offset J� SnapsToDevicePixels �� Triggers P� Property P� Value��%R	  &	        �� 5   
   " ��6)   .�5      ��  � �� 5      �� 5      " ��6&   .R�5      � $
 grid��6   $ 0.5,0.5&�6-   z�5      V� 5   "   .~�5   &   �� �� 5   &   �� 5   &   T� 5   &   5   #   	 5        5   "   CommonStates��
 5   &     5   *   $ 0:0:0.5D�6;   . 5    &     
Normal��62     5!   &   	MouseOver��. 5"   *   �� .��5#   .   U� $V P(UIElement.RenderTransform).(TransformGroup.Children)[0].(ScaleTransform.ScaleX)�6L   $
 grid��6�   .\�5$   2     $ 0��6G   $ 1.115Q�6S   5%   /   U� 5&   .   $V P(UIElement.RenderTransform).(TransformGroup.Children)[0].(ScaleTransform.ScaleY)�6L   $
 grid��6�   .\�5'   2     $ 0��6G   $ 1.115Q�6S   5(   /   U� 5)   .   $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.X)�6L   $
 grid��6�   .\�5*   2     $ 0��6G   $ 6Q�6S   5+   /   U� 5,   .   $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.Y)�6L   $
 grid��6�   .\�5-   2     $ 0��6G   $ 6Q�6S   5.   /   5/   +   50   '     51   &   Pressed��62     52   &   Disabled��62   53   #   .+�55      A� ���	#FFFD0202��56   "   �� 57   &   $ 0.497,0&�6:   $ 0.503,1&�6M   .��58   *   � $ 	#7EF70C0C��67   $ 0.017Q�6I   � 59   *   $ White��67   $ 1Q�6E   5:   '   5<      �� 5=      #��z��6/   ��. # z 6�   #��z��6�   $�� ��6  A� 5>      $��5,1.178,4,5q�6&   ��6;   Z� ��5?   "   �� 5@   &   $ 0.488,0&�6:   $ 0.512,1&�6M   .��5A   *   � $ 	#FFF5F1F1��67   $ 0Q�6I   � 5B   *   $ 1Q�67   � 5C   *   $ 	#FFF5F1F1��67   5D   '   5F      A� 5G      $��18��6&   $��	37,3,32,0q�62   $	��Top=�6W   ��6E   Z� ��5H   "   �� 5I   &   $ 0.488,0&�6:   $ 0.512,1&�6M   .��5J   *   � $ 	#00F5F1F1��67   $ 0Q�6I   � 5K   *   $ White��67   $ 1Q�6E   � 5L   *   $ 	#FFF5F1F1��67   $ 0.526Q�6I   5M   '   5O      �� 5P      $��16,16,15,15q�6$   $��Resources/Images/x.png��69   $
��Fill=�6Y   5Q       5R      P� 5S       �@J�	IsFocused . 6;   P� 5T       �@��IsDefaulted . 6=   P� 5U       �@J�IsMouseOver . 6=   P� 5V       � �� . 6;   P� 5W       � {� .  6;   5Y      5[      5\      5^      .��5_      �  � RowDefinitions 5`   
   �� 5a      $	��104 �6   6-   �� 5b      $
��562* �6   6,   .+�5d   
   �� -   5         ��Name$ closeButton��5d      #���   6&   $��Right=�6Q   $	��104��6m   $	��Top=�6z   $	��104��6�   $��0,1,3,0q�6�   $��2��6�   �� 5e   
   -   5        $��
textBlock1��5e   N   $��73��6   $
��Left=�6    $��	69,22,0,0q�6;   $��See other locations��6`   $	��Top=�6{   $	��465��6�   $��45(�6�   �� 5f   
   $��1��6   $��0,6,0,0q�6$   .��5g      ��  �� Orientation$ Vertical=�6   $��0,6,17,0q�60   $��1��6B   .+�5h      �� -   5        $��button2��5h   f   $!��Southcentre Mall: In stock!��6   $��64��6?   $
��Left=�6K   $	��Top=�6u   $	��645��6�   $��40(�6�   �� 5i      -   5        $��mapToSouthcenter��5i      $��0��60   $��0��6;   6G   �� 5j      -   5        $��button3��5j   `   $��Maket Mall: In stock!��6   $��65��69   $
��Left=�6E   $	��Top=�6o   $	��645��6�   $��40(�6�   6�   �� 5k      -   5        $��mapToMarket��5k      $��0��6+   $��0��66   6B   �� 5l      -   5        $��button4��5l   g   $"��Sunridge Mall: Out of Stock!��6   $��62��6@   $
��Left=�6L   $	��Top=�6v   $	��645��6�   $��40(�6�   �� 5m      -   5        $��mapToSunridge��5m      $��0��6-   $��0��68   6D   �� 5n      -	   5        $��button5��5n   n   $)��#CrossIron Mills Mall: Out of Stock!��6   $��61��6G   $
��Left=�6S   $	��Top=�6}   $	��645��6�   $��40(�6�   �� 5o      -
   5        $��mapToCrossIron��5o      $��0��6.   $��0��69   6E   5p      5q      5r      5s      