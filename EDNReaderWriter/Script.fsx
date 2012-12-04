﻿namespace EDNReader

//Evaluate the following block to load everything you need into the F# interactive
//START
#I "C:\\dev\\edn-dot-net\\EDNReaderWriter\\bin\\Debug";;
#r "FParsec";;
#r "FParsecCS";;
#r "EDNTypes";;

open FParsec;;

#load "C:\\dev\\edn-dot-net\\EDNReaderWriter\\EDNParserTypes.fs";;
open EDNReaderWriter.EDNParserTypes;;
#load "C:\\dev\\edn-dot-net\\EDNReaderWriter\\TypeHandlers.fs";;
open EDNReaderWriter.TypeHandlers;;
#load "C:\\dev\\edn-dot-net\\EDNReaderWriter\\EDNParser.fs";;
open EDNReaderWriter.EDNParser;;
#load "C:\\dev\\edn-dot-net\\EDNReaderWriter\\EDNReader.fs";;
open EDNReaderWriter.EDNReader;;
//END



// Tests
(*

run (many1 parseValue) "#tag 1"  |> getValueFromResult |> List.map (defaultHandlerFuncMap defaultTagHandler) ;;

runParserOnFile (many1 parseValue) () "C:\\dev\\edn-test-data\\floats.edn" System.Text.Encoding.UTF8 |> getValueFromResult |> List.map (defaultHandlerFuncMap defaultTagHandler) ;;

runParserOnFile (many1 parseValue) () "C:\\dev\\edn-test-data\\numbers.edn" System.Text.Encoding.UTF8 |> getValueFromResult |> List.map (defaultHandlerFuncMap defaultTagHandler) 

runParserOnFile (many1 parseValue) () "C:\\dev\\edn-test-data\\hierarchical.edn" System.Text.Encoding.UTF8 |> getValueFromResult |> List.map (defaultHandlerFuncMap defaultTagHandler) ;;
*)