   M S B A M L   `   `   `  ����B  >Library, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:LibraryLibrary  5   	       Library.LoginWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Library     5   	     � Title$  Login��5   	   $	��200��6   $	��310��6$    � Icon$ library.ico��60   ��5	      �� 5
   
    �� EndPoint$ 0.5,1&�6    �� 
StartPoint$ 0.5,0&�6/   .��5      �  � Color$ 	#FFF0A244��6    � Offset$ 0Q�6-   � 5      $ 	#FFF0A244��6   $ 1Q�6-   � 5      $ 	#FFF0C944��6   $ 0.508Q�6-   5      .��5      �  � ColumnDefinitions 5   
   �� 5      $	��79* �6   �� 5      $	��67* �6   .+�5   
   �� -   5         ��Name$ 
loginLabel��5      $��Login��6$   $
��Left=�64   $��	43,36,0,0q�6O   $	��Top=�6b   $��87��6z   $��Arial Rounded MT Bold)�6�   �� 5   
   -   5        $ passwordLabel��5      $��Password��6'   $
��Left=�6:   $��	43,70,0,0q�6U   $	��Top=�6h   $��87��6�   $��Arial Rounded MT Bold)�6�   �� 5   
   -   5         ��Name$ loginTextBox��5      $��2��6(   $
��Left=�6<   $��25��6W   $��
135,38,0,0q�6c   	 �� TextWrapping$
	 Wrap=�6w   $	��Top=�6�   $	��120��6�   $
��user��6�   $��Arial Rounded MT Bold)�6�   G� 5   
   -   5        
 G�Name$
 passwordBox��5      $
��Left=�6+   $��
135,72,0,0q�6F   $	��Top=�6Z   $��2��6r   $	��120��6�    J� RenderTransformOrigin$ 0.5,0.5&�6�   $��22��6�    G� Password$	 123��6�   �� 5   
   -   5         ��Name$ loginButton��5      $��2��6&   $��Login��6:   $
��Left=�6J   $��114,122,0,0q�6e   $	��Top=�6z   $��78��6�   $��25��6�   
���   �$��2q�6�   ���	#FFE4B89A$��Cooper Black)�6  5      5      