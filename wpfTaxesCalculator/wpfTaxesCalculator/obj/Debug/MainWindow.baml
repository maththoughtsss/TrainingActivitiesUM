   M S B A M L   `   `   `  ����M  IwpfTaxesCalculator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:wpfTaxesCalculatorwpfTaxesCalculator  5   	   #    wpfTaxesCalculator.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:wpfTaxesCalculator     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � .+�5
   
   �� -   5         ��Name$ lblTitle��5
      $��Cálculadora de Impuestos��6"   $��Center=�6E   $��41��6b   $��0,10,0,0q�6n   $	��Top=�6�   $	��800��6�   $��Center=�6�   $��21(�6�   �� 5   
   -   5        $ 	lblAmount��5      $��Ingrese el monto:��6#   $
��Left=�6?   $��
64,120,0,0q�6Z   $	��Top=�6n   $��16(�6�   �� 5   
   -   5        $ lblTax��5      $+��%Ingrese el % de impuestos a calcular:��6    $
��Left=�6P   $��
64,188,0,0q�6k   $	��Top=�6   $��16(�6�   �� 5   
   -   5        $ lblAmountResult��5      $$��Total del monto sin impuestos:��6)   $
��Left=�6R   $��
64,287,0,0q�6m   $	��Top=�6�   $��16(�6�   �� 5   
   -   5        $ lblTaxResult��5      $1��+Total de monto correspondiente a impuestos:��6&   $
��Left=�6\   $��
64,353,0,0q�6w   $	��Top=�6�   $��16(�6�   �� 5   
   -   5         ��Name$ 	txtAmount��5      $
��Left=�6%   $��400,120,0,0q�6@    �� TextWrapping$
 Wrap=�6U   $	��Top=�6i   $	��159��6�   $��28��6�   $��16(�6�   $��Center=�6�   �� 5   
   -   5        $ txtTax��5      $
��Left=�6"   $��400,188,0,0q�6=   $
 Wrap=�6R   $	��Top=�6f   $	��159��6~   $��28��6�   $��16(�6�   $��Center=�6�   �� 5   
   -   5        $ lblAmountWithoutTaxes��5      $�� ��6/   $
��Left=�6:   $��400,287,0,0q�6U   $	��Top=�6j   $	��159��6�   $��16(�6�   $��Center=�6�   $��31��6�   $��Center=�6�   �� 5   
   -	   5        $ lblTotalAmountTaxes��5      $�� ��6-   $
��Left=�68   $��400,353,0,0q�6S   $	��Top=�6h   $	��159��6�   $��16(�6�   $��Center=�6�   $��31��6�   �� 5   
   -
   5         ��Name$ btnCalculate��5      $��Calcular��6'   $
��Left=�6:   $��577,120,0,0q�6U   $	��Top=�6j   $	��159��6�   $��26��6�   $��15(�6�   6�   �� 5   
   -   5        $ btnClean��5      $��Limpiar��6#   $
��Left=�65   $��577,188,0,0q�6P   $	��Top=�6e   $	��159��6}   $��28��6�   $��15(�6�   6�   �� 5   
   -   5        $ btnExit��5      $��Salir��6"   $
��Left=�62   $��577,353,0,0q�6M   $	��Top=�6b   $	��159��6z   $��31��6�   $��15(�6�   6�   5      5      