﻿Option Strict Off
Option Explicit Off

Module ChangeNameFunctions

    Public Function ChangePokedexTypeName(ByVal Index As Integer, ByVal NewName As String)
        Dim offvar As Long

        offvar = Int32.Parse((GetString(AppPath & "ini\roms.ini", header, "PokedexData", "")), System.Globalization.NumberStyles.HexNumber)

        If header3 = "J" Then

            If header2 = "AXP" Or header2 = "AXV" Then
                SkipVar = "36"
            ElseIf header2 = "BPR" Or header2 = "BPG" Then
                SkipVar = "36"
            ElseIf header2 = "BPE" Then
                SkipVar = "32"
            End If

        Else
            If header2 = "AXP" Or header2 = "AXV" Then
                SkipVar = "36"
            ElseIf header2 = "BPR" Or header2 = "BPG" Then
                SkipVar = "36"
            ElseIf header2 = "BPE" Then
                SkipVar = "32"
            End If
        End If

        If header3 = "J" Then

        Else

            FileNum = FreeFile()
            FileOpen(FileNum, LoadedROM, OpenMode.Binary)
            Dim PokeType As String = "xxxxxxxxxxx"
            Dim filler As Byte = "&HFF"
            PokeType = NameAsc2Sapp(NewName)
            FilePut(FileNum, PokeType, offvar + 1 + (SkipVar * Index))
            FilePut(FileNum, filler, offvar + 1 + (SkipVar * Index) + Len(NewName))


        End If
        FileClose(FileNum)
        ChangePokedexTypeName = NewName
    End Function
    Public Function ChangePokemonName(ByVal Index As Integer, ByVal NewName As String)
        Dim offvar As Long

        offvar = Int32.Parse((GetString(AppPath & "ini\roms.ini", header, "PokemonNames", "")), System.Globalization.NumberStyles.HexNumber)

        If header3 = "J" Then

        Else

            FileNum = FreeFile()
            FileOpen(FileNum, LoadedROM, OpenMode.Binary)
            Dim PokeName As String = "xxxxxxxxxx"
            Dim filler As Byte = "&HFF"
            PokeName = NameAsc2Sapp(NewName)
            FilePut(FileNum, PokeName, offvar + 1 + (11 * Index))
            FilePut(FileNum, filler, offvar + 1 + (11 * Index) + Len(NewName))


        End If
        FileClose(FileNum)
        ChangePokemonName = NewName
    End Function

    Public Function ChangeAttackName(ByVal Index As Integer, ByVal NewName As String)
        Dim offvar As Integer

        offvar = Int32.Parse((GetString(AppPath & "ini\roms.ini", header, "AttackNames", "")), System.Globalization.NumberStyles.HexNumber)

        If header3 = "J" Then

        Else

            FileNum = FreeFile()
            FileOpen(FileNum, LoadedROM, OpenMode.Binary)
            Dim PokeName As String = "xxxxxxxxxxxxx"
            Dim filler As Byte = "&HFF"
            PokeName = NameAsc2Sapp(NewName)
            FilePut(FileNum, PokeName, offvar + 1 + (13 * Index))
            FilePut(FileNum, filler, offvar + 1 + (13 * Index) + Len(NewName))


        End If
        FileClose(FileNum)
        ChangeAttackName = NewName
    End Function

    Public Function ChangeAbilityName(ByVal Index As Integer, ByVal NewName As String)
        Dim offvar As Long

        offvar = Int32.Parse((GetString(AppPath & "ini\roms.ini", header, "AbilityNames", "")), System.Globalization.NumberStyles.HexNumber)

        If header3 = "J" Then

        Else

            FileNum = FreeFile()
            FileOpen(FileNum, LoadedROM, OpenMode.Binary)
            Dim PokeName As String = "xxxxxxxxxxxxxx"
            Dim filler As Byte = "&HFF"
            PokeName = NameAsc2Sapp(NewName)
            FilePut(FileNum, PokeName, offvar + 1 + (13 * Index))
            FilePut(FileNum, filler, offvar + 1 + (13 * Index) + Len(NewName))


        End If
        FileClose(FileNum)
        ChangeAbilityName = NewName
    End Function

    Public Function ChangeBattleFrontierTrainerName(ByVal Index As Integer, ByVal NewName As String)
        Dim offvar As Long

        offvar = Int32.Parse((GetString(AppPath & "ini\roms.ini", header, "BattleFrontierTrainers", "")), System.Globalization.NumberStyles.HexNumber)
        If header2 = "BPE" Then
            If header3 = "J" Then

            Else

                FileNum = FreeFile()
                FileOpen(FileNum, LoadedROM, OpenMode.Binary)
                Dim PokeName As String = "xxxxxxxx"
                Dim filler As Byte = "&HFF"
                PokeName = NameAsc2Sapp(NewName)
                FilePut(FileNum, PokeName, offvar + 1 + 4 + (Index * 52))
                FilePut(FileNum, filler, offvar + 1 + 4 + (Index * 52) + Len(NewName))


            End If
            FileClose(FileNum)
            ChangeBattleFrontierTrainerName = NewName
        Else
            MsgBox("What did you do? Contact Gamer2020")
            End
        End If
    End Function
End Module
