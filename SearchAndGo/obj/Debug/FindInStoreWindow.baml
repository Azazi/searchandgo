   M S B A M L   `   `   `  ����  SearchAndGo#    SearchAndGo.FindInStoreWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Find in Store��5   	    � WindowStartupLocation$ CenterScreen=�5   	    � AllowsTransparency .  � WindowStyle$
 None=�5   #   $��Center=�5   	   $��Center=�6&   $	��800��5   	   $	��800��6   ��5   6   Z�  � 	Resources 5	         ButtonStyleClose �� 
TargetType �� Property �� Value �� 
TargetType	 �Name
 J� RenderTransformOrigin'  !System.Windows.VisualStateManager   VisualStateGroups%  System.Windows.VisualStateGroup   Transitions%  System.Windows.VisualTransition   GeneratedDuration   States   System.Windows.VisualState   
Storyboard �� TargetProperty �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime O� Value �� EndPoint �� 
StartPoint � Color � Offset J� SnapsToDevicePixels �� Triggers P� Property P� Value��%R	  &	        �� 5
      " ��6#   .�5      ��  � �� 5      �� 5      " ��6   .R�5      � $
	 grid��6   $
 0.5,0.5&�6   z�5   	   V� 5   
   .~�5      �� �� 5      �� 5      T� 5      5       5   	     5   
   CommonStates�� 5        5      $ 0:0:0.5D�6   . 5        
Normal��6     5      	MouseOver��. 5      �� .��5      U� $V P(UIElement.RenderTransform).(TransformGroup.Children)[0].(ScaleTransform.ScaleX)�6+   $
 grid��6�   .\�5         $ 0��6#   $ 1.115Q�6/   5!      U� 5"      $V P(UIElement.RenderTransform).(TransformGroup.Children)[0].(ScaleTransform.ScaleY)�6+   $
 grid��6�   .\�5#        $ 0��6#   $ 1.115Q�6/   5$      U� 5%      $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.X)�6+   $
 grid��6�   .\�5&        $ 0��6#   $ 6Q�6/   5'      U� 5(      $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.Y)�6+   $
 grid��6�   .\�5)        $ 0��6#   $ 6Q�6/   5*      5+      5,        5-      Pressed��6     5.      Disabled��6   5/      .+�51   	   A� ���	#FFFD0202��52   
   �� 53      $ 0.497,0&�6   $ 0.503,1&�62   .��54      � $ 	#7EF70C0C��6   $ 0.017Q�6+   � 55      $ White��6   $ 1Q�6'   56      58   
   �� 59   	   #��z��6   ��. # z 6x   #��z��6�   $�� ��6�   A� 5:   	   $��5,1.178,4,5q�6   ��6&   Z� ��5;   
   �� 5<      $ 0.488,0&�6   $ 0.512,1&�62   .��5=      � $ 	#FFF5F1F1��6   $ 0Q�6+   � 5>      $ 1Q�6   � 5?      $ 	#FFF5F1F1��6   5@      5B   
   A� 5C   	   $��18��6   $��	37,3,32,0q�6   $	��Top=�6B   ��60   Z� ��5D   
   �� 5E      $ 0.488,0&�6   $ 0.512,1&�62   .��5F      � $ 	#00F5F1F1��6   $ 0Q�6+   � 5G      $ White��6   $ 1Q�6'   � 5H      $ 	#FFF5F1F1��6   $ 0.526Q�6+   5I      5K   
   �� 5L   	   $��16,16,15,15q�6   $��Resources\Images\x.png��6$   $
��Fill=�6D   5M   	    5N      P� 5O   	    �@J�	IsFocused . 6&   P� 5P   	    �@��IsDefaulted . 6(   P� 5Q   	    �@J�IsMouseOver . 6(   P� 5R   	    � �� . 6&   P� 5S   	    � {� .  6&   5U      5W      5X      5Y      .��5Z      � -   5        $
��grid��5Z      
������ .+�5[   
   �� -   5        $��windowCanvas��5[      $��Center=�6%   $��Center=�6B   $	��700��6]   $	��700��6i   ���	#FFF7F7F5.+�5\      �� $��2q�6   
���   �$	��700��6=   $	��700��6J   ._�5]      �� -   5        $	��map��5]      $��Resources\Images\map.png��6#   $��	1,-2,3,-2q�6E   5^      5_      �� 5`   
   -   5        $��closeButton��5`      #���   6$   $��Right=�6O   $	��104��6k   $	��Top=�6x   $	��104��6�   $��0,0,12,0q�6�   5a      5b      