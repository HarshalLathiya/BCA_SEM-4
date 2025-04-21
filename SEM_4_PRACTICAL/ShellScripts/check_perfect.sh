#!/bin/bash
read -p "Enter a number: " num
sum=0
for (( i=1; i<num; i++ ))
do
    if (( num % i == 0 )); then
        sum=$((sum + i))
    fi
done
if [ $sum -eq $num ]; then
    echo "Perfect number"
else
    echo "Not a perfect number"
fi