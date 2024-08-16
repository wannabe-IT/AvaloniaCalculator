using System;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace AvaloniaCalc;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        Width = 230;
        Height = 300;
    }

    private float _floatNum1, _floatNum2, _floatNum;
    private char _znamenko;
    
    private void GetFloatA()
    {
       bool parseA = float.TryParse(DisplayBlock.Text, out _floatNum1);
    }
            
    private void GetFloatB()
    { 
       bool parseB = float.TryParse(DisplayBlock.Text, out _floatNum2);
    }
    private void Nine(object? sender, RoutedEventArgs e)
    {
        if (DisplayBlock.Text == "0")
            DisplayBlock.Text = "9";
        else
            DisplayBlock.Text += 9;
    }

    private void Eight(object? sender, RoutedEventArgs e)
    {
        if (DisplayBlock.Text == "0")
            DisplayBlock.Text = "8";
        else
            DisplayBlock.Text += 8;
    }
    private void Seven(object? sender, RoutedEventArgs e)
    {
        if (DisplayBlock.Text == "0")
            DisplayBlock.Text = "7";
        else
            DisplayBlock.Text += 7;
    }
    private void Six(object? sender, RoutedEventArgs e)
    {
        if (DisplayBlock.Text == "0")
            DisplayBlock.Text = "6";
        else
            DisplayBlock.Text += 6;
    }
    private void Five(object? sender, RoutedEventArgs e)
    {
        if (DisplayBlock.Text == "0")
            DisplayBlock.Text = "5";
        else
            DisplayBlock.Text += 5;
    }
    private void Four(object? sender, RoutedEventArgs e)
    {
        if (DisplayBlock.Text == "0")
            DisplayBlock.Text = "4";
        else
            DisplayBlock.Text += 4;
    }
    private void Three(object? sender, RoutedEventArgs e)
    {
        if (DisplayBlock.Text == "0")
            DisplayBlock.Text = "3";
        else
            DisplayBlock.Text += 3;
    }
    private void Two(object? sender, RoutedEventArgs e)
    {
        if (DisplayBlock.Text == "0")
            DisplayBlock.Text = "2";
        else
            DisplayBlock.Text += 2;
    }
    private void One(object? sender, RoutedEventArgs e)
    {
        if (DisplayBlock.Text == "0")
            DisplayBlock.Text = "1";
        else
            DisplayBlock.Text += 1;
    }
    private void Zero(object? sender, RoutedEventArgs e)
    {
        if (DisplayBlock.Text == "0")
            DisplayBlock.Text = "0";
        else
            DisplayBlock.Text += 0;
    }
    private void Plus(object? sender, RoutedEventArgs e)
    {
        GetFloatA();
        _znamenko = '+';
        DisplayBlock.Text = "0";
    }
    private void Minus(object? sender, RoutedEventArgs e)
    {
        GetFloatA();
        _znamenko = '-';
        DisplayBlock.Text = "0";
    }
    private void Krat(object? sender, RoutedEventArgs e)
    {
        GetFloatA();
        _znamenko = '*';
        DisplayBlock.Text = "0";
    }
    private void Deleno(object? sender, RoutedEventArgs e)
    {
        GetFloatA();
        _znamenko = '/';
        DisplayBlock.Text = "0";
    }

    private void DelLastNum(object? sender, RoutedEventArgs e)
    {
        if (DisplayBlock.Text.Length > 1)
        {
            DisplayBlock.Text = DisplayBlock.Text.Remove(DisplayBlock.Text.Length - 1);
        }
        else
        {
            DisplayBlock.Text = "0";
        }
    }
    private void Rovnase(object? sender, RoutedEventArgs e)
    {
        string displayResult;
        GetFloatB();
        
        switch (_znamenko)
        {
            case '+':
                _floatNum = _floatNum1 + _floatNum2;
                break;
            case '-':
                _floatNum = _floatNum1 - _floatNum2;
                break;
            case '*':
                _floatNum = _floatNum1 * _floatNum2;
                break;
            case '/':
                _floatNum = _floatNum1 / _floatNum2;
                break;
        }
        _floatNum = (float)Math.Round(_floatNum, 2);
        if (_floatNum1 == (int)_floatNum1 && _floatNum2 == (int)_floatNum2 && _floatNum == (int)_floatNum)
            displayResult = ((int)_floatNum).ToString();
        else
            displayResult = _floatNum.ToString();

        DisplayBlock.Text = displayResult;
        _floatNum1 = 0;
        _floatNum2 = 0;
    }
    private void Desetinna(object? sender, RoutedEventArgs e)
    {
        DisplayBlock.Text += ',';
    }

    private void PlusMinusButton(object? sender, RoutedEventArgs e)
    {
        DisplayBlock.Text = "-";
        int negativeNumber = DisplayBlock.Text.IndexOf('-');
        if (negativeNumber != -1)
        {
            if (_floatNum1 != 0)
            {
                _floatNum2 *= -1;
            }
            else
            {
                _floatNum1 *= -1;
            }
        }
    }
    private void ResetButton(object? sender, RoutedEventArgs _)
    {
        DisplayBlock.Text = "0";
        _floatNum1 = 0;
        _floatNum2 = 0;
        _floatNum = 0; 
    }
}