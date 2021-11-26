from random import *
from tkinter import *
from tkinter import messagebox


def buttonclick():
    messagebox.showinfo('게임설명','1000~9999 사이의 중복되지 않은 값을 입력하시오. 값은 맞지만 자리가 다르면 볼, 값과 자리가 같으면 스트라이크입니다.')
def quit():
    messagebox.showinfo('종료','게임을 종료합니다.')
    w.destroy()
    w.quit()
def check():
    global trynum
    while True:
        trynum+=1
        mynum=int(lbl2.get())
        if mynum < 1000 or mynum > 9999:
            messagebox.showinfo('결과','잘못된 범위의 값을 입력하였습니다. 다시 입력하세요.')
            break
        m1 = mynum // 1000
        r2 = mynum % 1000
        m2 = r2 // 100
        r2 = r2 % 100
        m3 = r2 // 10
        r2 = r2 % 10
        m4 = r2

        if m1 == m2 or m1 == m3 or m1 == m4 or m2 == m3 or m2 == m4 or m3 == m4:
            messagebox.showinfo('결과','중복된 값을 입력하였습니다. 다시 입력하세요.')
            break
        # 각 자리값 비교
        strike = 0
        ball = 0

        if m1 == n1:
            strike += 1
        elif m1 == n2:
            ball += 1
        elif m1 == n3:
            ball += 1
        elif m1 == n4:
            ball += 1
        if m2 == n1:
            ball += 1
        elif m2 == n2:
            strike += 1
        elif m2 == n3:
            ball += 1
        elif m2 == n4:
            ball += 1
        if m3 == n1:
            ball += 1
        elif m3 == n2:
            ball += 1
        elif m3 == n3:
            strike += 1
        elif m3 == n4:
            ball += 1
        if m4 == n1:
            ball += 1
        elif m4 == n2:
            ball += 1
        elif m4 == n3:
            ball += 1
        elif m4 == n4:
            strike += 1
        messagebox.showinfo('결과','볼 = %d, 스트라이크 = %d' % (ball, strike))
        if strike==4:
            messagebox.showinfo('성공','게임을 클리어했습니다. 종료를 누르거나 새 게임을 시작하세요(도전 횟수:%d)'%trynum)
        else:
            messagebox.showinfo('실패','다시 시도하세요(도전 횟수:%d)'%trynum)
        break
def rannum():
    global trynum
    trynum=0
    while True:
        global num
        num = randint(1000, 9999)
        n1 = num // 1000
        r1 = num % 1000
        n2 = r1 // 100
        r1 = r1 % 100
        n3 = r1 // 10
        r1 = r1 % 10
        n4 = r1
        if n1 == n2 or n1 == n3 or n1 == n4 or n2 == n3 or n2 == n4 or n3 == n4:
            continue
        else:
            break
    lbl2.delete(0, END)
    messagebox.showinfo('새 게임', '값을 초기화합니다')


#메인 시작
trynum = 0
while True:
    num = randint(1000, 9999)
    n1 = num // 1000
    r1 = num % 1000
    n2 = r1 // 100
    r1 = r1 % 100
    n3 = r1 // 10
    r1 = r1 % 10
    n4 = r1
    if n1 == n2 or n1 == n3 or n1 == n4 or n2 == n3 or n2 == n4 or n3 == n4:
        continue
    else:
        break

w=Tk()
w.title('숫자야구 프로그램')
menubar=Menu(w)
f1=Menu(menubar,tearoff=0)
f1.add_command(label='게임 설명',command=buttonclick)
f1.add_command(label='새 게임',command=rannum)
f1.add_separator()
f1.add_command(label='게임 종료',command=quit)
menubar.add_cascade(label='File',menu=f1)
w.config(menu=menubar)
image=Frame(w)
top=Frame(w)
middle=Frame(w)
photo=PhotoImage(file='1.png')
lbl3=Label(image,image=photo)
lbl=Label(top,text='값을 입력하시오', bg='slategray2')
lbl2=Entry(middle)
lbl.pack()
lbl2.pack(side=LEFT,padx=10)
lbl3.pack()
btn2=Button(middle,text='확인',command=check, bg='slategray2')
btn2.pack(side=LEFT,padx=10)
image.pack()
top.pack()
middle.pack()
w.mainloop()
