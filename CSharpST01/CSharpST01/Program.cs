using System; //System 이라는 보따리를 사용하겠다.
using System.Collections.Generic; // System 안에 있는 Collections 보따리 안에 Generic 보따리르 사용한다
using System.Linq; // System 보따리 안에 Linq를 사용한다
using System.Text; // System 보따리 안에 Text를 사용.
using System.Threading.Tasks; //System.Threading.Tasks를 사용한다.
// 맨 위에 using System를 쓰다고 System 내의 모든 파일을 사용하는 것이 아니다.
// System 직접적 안에 있는 것이 아닌 그 더 깊숙한 파일을 필요시 System.Collections.Generic처럼 명시해줘야한다.

namespace CSharpST01 //  namespace ~~ -> 사용자 정의 ~~ 보따리를 만드는 것
{
    class Program //CSharpsST01보따리 안에 있는 Program 이라는 툴(Tool)을 windows OS가 사용.
        //Program이라는 Tool 내에 여러가지 기능이 있을 수 있다.(하나 일 수도 있음.)
    {
        static void Main(string[] args) //Main -> Program 의 기능중 하나. 항상 먼저 실행되는 함수. OS가 호출하는 함수는 Main뿐.
            //string[] args -> 인자. Main이라는 함수가 사용되기 위한 필요. 필수x
            //string -> 문자열. [] -> 배열. string[] -> 문자열이 한 두개가 아니라 여러개가 들어올 수 있다. args -> string [] 문자열 이름
        {
            Console/*Console에*/.WriteLine/*적어라*/("Hello CSharp");//Hello CSharp 라고
            Console.WriteLine(args.Length/*args의 문자열 배열의 갯수*/); //args에 아무것도 없기 때문에 0로 표기.
            //cmd로 실행하여 인자 입력 가능

            //Console.WriteLine("Hello" + args[0]); //args에 인자를 입력했을때 Hello 입력값이 표기됨.

            Console/* Console에*/.ReadKey();//사용자가 키 입력하는 것을 읽어라
        }
    }
}
