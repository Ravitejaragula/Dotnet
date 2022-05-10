<!DOCTYPE html>
<html lang="en">
<head>
    <title> JavaScript Calculator </title>
    <style>
        h1 {
            text-align: center;
            padding: 15px;
            background-color:red;
            color: white;
        }

        #clear {
            width: 258px;
            border: 3px solid gray;
            border-radius: 3px;
            padding: 10px;
            background-color: lightseagreen;
        }

        .formstyle {
            width: 663px;
            height: 352px;
            margin: auto;
            border: 3px solid green;
            border-radius: 5px;
            padding: 20px;
        }

        input {
            width: 55px;
            background-color: yellow;
            padding:10px;
            color: white;
            border: 3px solid gray;
            border-radius: 5px;
            margin: 5px;
            font-size: 15px;
        }

        #calc {
            width: 250px;
            border: 5px solid black;
            border-radius: 3px;
            padding: 20px;
            margin: auto;
        }
    </style>
</head>
<body>
    <h1> Scientific Calculator </h1>
    <div class="formstyle">
        <form name="form1">
            <input id="calc" type="text" name="answer"> <br> <br>
            <input type="button" value="1" onclick="form1.answer.value += '1' ">
            <input type="button" value="2" onclick="form1.answer.value += '2' ">
            <input type="button" value="3" onclick="form1.answer.value += '3' ">
            <input type="button" value="4" onclick="form1.answer.value += '4' ">
            <input type="button" value="5" onclick="form1.answer.value += '5' ">
            <input type="button" value="6" onclick="form1.answer.value += '6' ">
            <input type="button" value="7" onclick="form1.answer.value += '7' ">
            <input type="button" value="8" onclick="form1.answer.value += '8' ">
            <input type="button" value="9" onclick="form1.answer.value += '9' ">
            <input type="button" value="+" onclick="form1.answer.value += '+' ">
            <input type="button" value="-" onclick="form1.answer.value += '-' ">
            <input type="button" value="" onclick="form1.answer.value += '' ">
            <input type="button" value="/" onclick="form1.answer.value += '/' ">
            <input type="button" value="0" onclick="form1.answer.value += '0' ">
            <input type="button" value="." onclick="form1.answer.value += '.' ">
            <input type="button" value="tan" OnClick="form1.answer.value+='Math.tan('">
            <input id="btn" type="button" value="E" OnClick="form1.answer.value+='Math.E'">

            <input id="btn" type="button" value="pi" OnClick="form1.answer.value+='Math.PI'">
            <input id="btn" type="button" value="sin"
                   OnClick="form1.answer.value+='Math.sin('">
            <input id="btn" type="button" value="cos"
                   OnClick="form1.answer.value+='Math.cos('">
            <input id="btn" type="button" value="sec"
                   OnClick="form1.answer.value+='Math.sec('">


            <input id="btn" type="button" value="^"
                   OnClick="form1.answer.value+='Math.pow('">

            <input id="btn" type="button" value="("
                   OnClick="form1.answer.value+='('">

            <input id="btn" type="button" value=")"
                   OnClick="form1.answer.value+=')'">

            <input id="btn" type="button" value="log"
                   OnClick="form1.answer.value='Math.log('">
            <input id="btn" type="button" value="sqrt"
                   OnClick="form1.answer.value+='Math.sqrt('">

            <input id="btn" type="button" value="ln2"
                   OnClick="form1.answer.value+='Math.LN2'">
            <input id="btn" type="button" value="ln10"
                   OnClick="form1.answer.value+='Math.Log10'">
            <input id="btn" type="button" value="l2e"
                   OnClick="form1.answer.value+='Math.LOG2E'">

            <input id="btn" type="button" value="l10e"
                   OnClick="form1.answer.value+='Math.log10'">

            <input id="btn" type="button" value="exp"
                   OnClick="form1.answer.value='Math.exp('">
            <input type="button" value="=" onclick="form1.answer.value = eval(form1.answer.value)">

            <input type="button" value="Clear All" onclick="form1.answer.value = ' ' " id="clear">



        </form>
    </div>
</body>
</html>