#!/bin/bash
read -p "Enter number of rows: " n
for (( i=1; i<=n; i++ ))
do
    for (( j=i; j<n; j++ ))
    do
        echo -n " "
    done
    for (( k=1; k<=(2*i-1); k++ ))
    do
        echo -n "*"
    done
    echo
done