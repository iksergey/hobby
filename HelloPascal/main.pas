program main;
uses crt;
var 
  text, output: string;
  i: integer;
begin
  clrscr;
  Write('text = ');
  ReadLn(text);
  output := 'Hello, ' + text + '!';
  {WriteLn(output);}
  for i:=1 to Length(output) do
  begin
    Write(output[i],' ');
  end;
  WriteLn();
end.