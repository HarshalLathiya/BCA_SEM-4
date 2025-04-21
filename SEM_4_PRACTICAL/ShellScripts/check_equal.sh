#!/bin/bash
read -p "Enter first number: " a
read -p "Enter second number: " b
if [ $a -eq $b ]; then
    echo "Numbers are equal"
else
    echo "Numbers are not equal"
fi