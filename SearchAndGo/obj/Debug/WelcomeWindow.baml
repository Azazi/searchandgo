   M S B A M L   `   `   `  ����  SearchAndGo    SearchAndGo.WelcomeWindow   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     6B     � Title$  Search and Go��5       � WindowStartupLocation$ CenterScreen=�5       � WindowState$ 	Maximized=�5       � WindowStyle$
 None=�5       � 	Resources 5	         ButtonStyleEn �� 
TargetType �� Property �� Value �� 
TargetType'  !System.Windows.VisualStateManager	   VisualStateGroups%  System.Windows.VisualStateGroup
   Transitions%  System.Windows.VisualTransition   GeneratedDuration   States   System.Windows.VisualState   
Storyboard �� TargetProperty �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime O� Value ��Name � ToolTip � Cursor J� RenderTransformOrigin J� SnapsToDevicePixels J� Opacity �� Triggers P� Property P� Value  ButtonStyleFr��%
  &	        &	 �    �� 5
      " ��6    .�5      ��  � �� 5      �� 5      " ��6   .R�5      � 	 5   	     5   
   CommonStates��
 5        5      $ 0:0:0.5D�6   . 5        
Normal��6     5      	MouseOver��. 5      �� .��5      U� $ (UIElement.Opacity)�6+   $ 
image_Copy��6[   .\�5        $ 0��6#   $ 1Q�6/   5      5      5        5      Pressed��. 5      �� .��5      U� $ (UIElement.Opacity)�6+   $ image��6[   .\�5        $ 0��6#   $ 0.595Q�6/   5       5!      5"        5#      Disabled��6   5$      .+�5&   	   �� $ image��6   $��EN.png��6   $
��Fill=�6.   $ English��6=   $
 Hand��6O   $ 0.5,0.5&�6]   z�5'   
   V� 5(      .~�5)      �� �� 5*      �� 5+      T� 5,      5-      5/   
   �� 50   	   #��z��6   ��. # z 6x   #��z��6�   �� 51   	   $ 
image_Copy��6   $��EN.png��6#   $
��Fill=�63   $ English��6B   $
 Hand��6T   $ 0.5,0.5&�6b   $ 0Q�6�   z�52   
   V� 53      .~�54      �� �� 55      �� 56      T� 57      58      5:   
   5;   	    5<      P� 5=   	    �@J�	IsFocused . 6&   P� 5>   	    �@��IsDefaulted . 6(   P� 5?   	    �@J�IsMouseOver . 6(   P� 5@   	    � �� . 6&   P� 5A   	    � {� .  6&   5C      5E      5F      �� 5G      " ��6    .�5H      ��  � �� 5I      �� 5J      " ��6   .R�5K      � 	 5L   	     5M   
   CommonStates��
 5N        5O      $ 0:0:0.5D�6   . 5Q        
Normal��6     5R      	MouseOver��. 5S      �� .��5T      U� $ (UIElement.Opacity)�6+   $ image��6[   .\�5U        $ 0��6#   $ 1Q�6/   5V      5W      5X        5Y      Pressed��. 5Z      �� .��5[      U� $ (UIElement.Opacity)�6+   $ image1��6[   .\�5\        $ 0��6#   $	 0.6Q�6/   5]      5^      5_        5`      Disabled��6   5a      .+�5c   	   �� $ image1��6   $��FR.png��6   $
��Fill=�6/   $
 Hand��6>   $ Francis��6L   �� 5d   	   #��z��6   ��. # z 6x   #��z��6�   �� 5e   	   $ image��6   $��FR.png��6   $
��Fill=�6.   $
 Hand��6=   $ Francis��6K   $ 0Q�6]   5f   	    5g      P� 5h   	    �@J�	IsFocused . 6&   P� 5i   	    �@��IsDefaulted . 6(   P� 5j   	    �@J�IsMouseOver . 6(   P� 5k   	    � �� . 6&   P� 5l   	    � {� .  6&   5n      5p      5q      5r      ��5t      �� 5u   
    �� ImageSource$I C/SearchAndGo;component/Resources/Images/welcomeScreenBackground.jpg��6   .��5w      � .+�5~   
   �� -   5         ��Name$ 
separator1��5~   X   $��20��6   $��Center=�6    $��Center=�6=   $
��1000��6l   ���	#FFE81212���	#FFEF2B2B6�   �� 5   
   -   5         ��Name$ touchToStartButton��5      $	��218��6-   $	��893��6:   $��	0,0,0,500q�6F   $��Center=�6Y   #���   6v   �� 5�   
   -   5        $��touchezPourDemarrerButton��5�      $	��893��62   $	��218��6>   $��
0,0,0,-500q�6K   #���  6_   $��Center=�6�   5�      5�      