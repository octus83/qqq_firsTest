   M S B A M L   `   `   `  ����B  >TestBay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:TestBay.ViewModelsTestBay.ViewModels  5   	       TestBay.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   /vm clr-namespace:TestBay.ViewModels     5   	     � Title$  
MainWindow��5   	   $	��350��6   $	��525��6)    � DataContext 5      &    TestBay.ViewModels.ViewModelBase  5   
   .��5      �  � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      $��* �6   .+�5   
   �� $��0��6    �� Orientation$ 
Horizontal=�6"   .+�5      �� $	��100��6   $��5q�6!   $��	FirstView��6K   ��6,   �� *
SwitchView+.��6h   	FirstView6s   �� 5      $	��100��6   $��5q�6!   $��
SecondView��6K   ��6,   �� *
SwitchView+.��6i   
SecondView6u   5      �� 5   
   $��1��6   ��6(   �� *
ViewToShow+5      5      5      