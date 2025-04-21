#!/bin/bash
read -p "Enter a number: " num
temp=$num
sum=0
while [ $temp -gt 0 ]
do
    digit=$(( temp % 10 ))
    sum=$(( sum + digit * digit * digit ))
    temp=$(( temp / 10 ))
done
if [ $sum -eq $num ]; then
    echo "Armstrong number"
else
    echo "Not an Armstrong number"
fi