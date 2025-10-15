#!/usr/bin/env bash


csc *.cs
if [[ $? -ne 0 ]]; then
	exit 1
fi

mono $@ main.exe

while [[ $# -gt 0 ]]; do
	case $1 in
		--profile=*)
			mprof-report output.mlpd | less
			shift
			;;
	esac
done
