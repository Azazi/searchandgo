   M S B A M L   `   `   `  ����  SearchAndGo    SearchAndGo.HelpWindow   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -   5        $��HelpUserControl��5        � WindowStartupLocation$  CenterScreen=�5      $��0q�5	       � WindowStyle$
 None=�5
      $
��1200��5      $	��800��5       � 	Resources 5         ButtonStyleClose �� 
TargetType �� Property �� Value �� 
TargetType �Name J� RenderTransformOrigin'  !System.Windows.VisualStateManager	   VisualStateGroups%  System.Windows.VisualStateGroup
   Transitions%  System.Windows.VisualTransition   GeneratedDuration   States   System.Windows.VisualState   
Storyboard �� TargetProperty �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime O� Value �� EndPoint �� 
StartPoint � Color � Offset J� SnapsToDevicePixels �� Triggers P� Property P� Value��%R	  &	        �� 5      " ��6#   .�5      ��  � �� 5      �� 5      " ��6   .R�5      � $
 grid��6   $ 0.5,0.5&�6   z�5   	   V� 5   
   .~�5      �� �� 5      �� 5      T� 5      5      	 5   	     5   
   CommonStates��
 5        5       $ 0:0:0.5D�6   . 5"        
Normal��6     5#      	MouseOver��. 5$      �� .��5%      U� $V P(UIElement.RenderTransform).(TransformGroup.Children)[0].(ScaleTransform.ScaleX)�6+   $
 grid��6�   .\�5&        $ 0��6#   $ 1.115Q�6/   5'      U� 5(      $V P(UIElement.RenderTransform).(TransformGroup.Children)[0].(ScaleTransform.ScaleY)�6+   $
 grid��6�   .\�5)        $ 0��6#   $ 1.115Q�6/   5*      U� 5+      $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.X)�6+   $
 grid��6�   .\�5,        $ 0��6#   $ 6Q�6/   5-      U� 5.      $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.Y)�6+   $
 grid��6�   .\�5/        $ 0��6#   $ 6Q�6/   50      51      52        53      Pressed��6     54      Disabled��6   55      .+�57   	   A� ���	#FFFD0202��58   
   �� 59      $ 0.497,0&�6   $ 0.503,1&�62   .��5:      � $ 	#7EF70C0C��6   $ 0.017Q�6+   � 5;      $ White��6   $ 1Q�6'   5<      5>   
   �� 5?   	   #��z��6   ��. # z 6x   #��z��6�   $�� ��6�   A� 5@   	   $��5,1.178,4,5q�6   ��6&   Z� ��5A   
   �� 5B      $ 0.488,0&�6   $ 0.512,1&�62   .��5C      � $ 	#FFF5F1F1��6   $ 0Q�6+   � 5D      $ 1Q�6   � 5E      $ 	#FFF5F1F1��6   5F      5H   
   A� 5I   	   $��18��6   $��	37,3,32,0q�6   $	��Top=�6B   ��60   Z� ��5J   
   �� 5K      $ 0.488,0&�6   $ 0.512,1&�62   .��5L      � $ 	#00F5F1F1��6   $ 0Q�6+   � 5M      $ White��6   $ 1Q�6'   � 5N      $ 	#FFF5F1F1��6   $ 0.526Q�6+   5O      5Q   
   �� 5R   	   $��16,16,15,15q�6   $��Resources/Images/x.png��6$   $
��Fill=�6D   5S   	    5T      P� 5U   	    �@J�	IsFocused . 6&   P� 5V   	    �@��IsDefaulted . 6(   P� 5W   	    �@J�IsMouseOver . 6(   P� 5X   	    � �� . 6&   P� 5Y   	    � {� .  6&   5[      5]      5^      5_      .��5a      � -   5        $��mainGrid��5a      .+�5c   
   �� -   5        $��
mainScroll��5c   *   $��	0,91,0,75q�6   .��5d      �� -   5        $��
manualText��5d      $
��1157��6*    �� TextAlignment$ Justify=�67   $
��Wrap=�6O   6e   5e      �� 5f   
   -   5        $��repHelp��5f   s   $6��0Request a Customer Service Representative's Help��6   $��65��6L   $
��Left=�6X   $	��Top=�6�   $	��899��6�   $��40(�6�   $��140,710,0,0q�6�   �� 5h   
   -   5         ��Name$ 
textBlock1��5h      $��106,213,122,78q�6(    � UseLayoutRounding . $
��Wrap=�6Y   $ Center=�6m   $��26.667(�6�   $C��=Customer service representative is on their way to assist you��6�   �� 5i   
   -   5        $��closeButton��5i   C   $�� ��6   $��80��6   $
��Left=�6(   $	��Top=�6V   $��80��6n   $��1079,12,0,0q�6�   #���   6�   �� 5j   
   -   5        $ textBlock1_Copy��5j      $��29,0,29,431q�6-    . $
��Wrap=�6[   $ Center=�6o   $��26.667(�6�   $��41��6�   $��Bottom=�6�   �� 6�   $
��Bold"�6�   $�Estimated wait time��6�   6�   �� 5k   
   -	   5        $ textBlock1_Copy1��5k      $��29,0,29,344q�6.    . $
��Wrap=�6\   $ Center=�6p   $��26.667(�6�   $��41��6�   $��Bottom=�6�   ���	#FFE20D0D�� 6�   $
��Bold"�6�   $�	2 Minutes��6�   6  �� 5l   
   -
   5        $��textBox1��5l   L   $��73��6   $
��Left=�6    $��3,2,0,0q�6;   $	��Top=�6\   $	��268��6t   $��	Help Page��6�   $��40(�6�   5m      5o      