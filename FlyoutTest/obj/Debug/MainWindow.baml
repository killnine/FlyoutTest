   M S B A M L   `   `   `  ����E  AFlyoutTest, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:FlyoutTest.ViewFlyoutTest.View  5   	       FlyoutTest.MainWindow   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   U QMahApps.Metro, Version=0.13.1.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4f;controls,http://metro.mahapps.com/winfx/xaml/controls  5   	   (viewclr-namespace:FlyoutTest.View  5   	     � Title$  
MainWindow��5   	   $	��350��6   $	��525��6)   (  "MahApps.Metro.Controls.MetroWindow   ShowWindowCommandsOnTop .   � DataContext 5   	   �� *
MainWindow+   Locator �� Source# [     Flyouts 5	      +  %MahApps.Metro.Controls.FlyoutsControl  5
   
   .@�5      #  MahApps.Metro.Controls.Flyout  -   5        $��	TaskSetup��5         Header$ 
Task Setup��6/      Position$ Right=�6C      IsModal .    Theme$ Adapt=�6c   	   IsOpen	 6q   �� *TaskSetupForm.IsOpen+.��5      '   !FlyoutTest.View.TaskSetupFormView  5      5      .��5      � 
 � RowDefinitions
 5   
   �� 5      �� 5      �� 5      .+�5   
   �� $��0��6   
�������$��3q�65   $��Working Flyout��6@   ��6Y   �� *OpenFlyoutCommand+�� 5   
   $��1��6   
�����w�$��3q�6:   $��Broken Flyout��6E   ��6]   �� *BrokenOpenFlyoutCommand+�� 5   
   $��2��6   
�����p�$��3q�62   5      5      