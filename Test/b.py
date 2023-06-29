import serial
from time import sleep

#python -m pip uninstall serial
#python -m pip install pyserial

#f = open("data.txt", "r")
ser = serial.Serial('COM16', 9600)

#ser.write(b'hello world!')
#print(ser.read(12))

#with open(r"data.txt", 'r') as fp:
#    countLine = len(fp.readlines())

#for i in range(countLine):
    #rline = f.readline()
    #bytes_encoded = rline.encode(encoding='utf-8')
    #ser.write(open("data.txt","rb").read())
    #ser.write(bytes_encoded)
    #print(ser.read(len(bytes_encoded)))
    #sleep(1)

with open("grvdatalog.txt") as file:
    content = file.readlines()
    alist = [x.encode('UTF-8') for x in content]
    #print(content)

    for i in range(len(content)):
        #ser.write(line.rstrip().encode(encoding='UTF-8'))
        #print(line.rstrip())
        ser.write(alist[i])
        sleep(0.9)

#ser.write(open("data.txt","rb").read())
ser.close()
