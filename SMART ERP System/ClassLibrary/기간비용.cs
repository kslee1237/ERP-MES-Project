//------------------------------------------------------------------------------
// <auto-generated>
//     이 코드는 템플릿에서 생성되었습니다.
//
//     이 파일을 수동으로 변경하면 응용 프로그램에서 예기치 않은 동작이 발생할 수 있습니다.
//     이 파일을 수동으로 변경하면 코드가 다시 생성될 때 변경 내용을 덮어씁니다.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClassLibrary
{
    using System;
    using System.Collections.Generic;
    
    public partial class 기간비용
    {
        public System.DateTime 기표일자 { get; set; }
        public int 기표번호 { get; set; }
        public int 거래처코드번호 { get; set; }
        public int 계정과목코드번호 { get; set; }
        public int 사용부서코드번호 { get; set; }
        public int 프로젝트코드번호 { get; set; }
        public int 업무용승용차코드번호 { get; set; }
        public string 적요 { get; set; }
        public System.DateTime 계약기간시작일 { get; set; }
        public System.DateTime 계약기간종료일 { get; set; }
        public int 금액 { get; set; }
        public System.DateTime 해지일자 { get; set; }
        public int 환급금액 { get; set; }
        public string 해지사유 { get; set; }
        public string 기간비용계산방법코드번호 { get; set; }
    
        public virtual 기간비용계산방법 기간비용계산방법 { get; set; }
    }
}
