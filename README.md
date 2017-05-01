# key-transmitter
Client and server for remote typing.
Targets .NET Framework 4.6.2.

## KeyTransmitter.Server
WPF-application accepting TCP connections and sending keyboard keys to OS. Server expects keys as integers with values corresponding to System.ConsoleKey enum codes.

## KeyTransmitter.Client
Small library providing simple interface for passing keys to remote server.

## KeyTransmitter.ConsoleClient
Simple CLI wrapper for KeyTransmitter.Client library.
