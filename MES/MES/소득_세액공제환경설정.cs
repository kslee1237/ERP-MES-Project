//------------------------------------------------------------------------------
// <auto-generated>
//     이 코드는 템플릿에서 생성되었습니다.
//
//     이 파일을 수동으로 변경하면 응용 프로그램에서 예기치 않은 동작이 발생할 수 있습니다.
//     이 파일을 수동으로 변경하면 코드가 다시 생성될 때 변경 내용을 덮어씁니다.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MES
{
    using System;
    using System.Collections.Generic;
    
    public partial class 소득_세액공제환경설정
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public 소득_세액공제환경설정()
        {
            this.공제별세부사항 = new HashSet<공제별세부사항>();
            this.근로소득별세부사항 = new HashSet<근로소득별세부사항>();
        }
    
        public System.DateTime 귀속연도 { get; set; }
        public string 구분명 { get; set; }
        public string 항목명 { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<공제별세부사항> 공제별세부사항 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<근로소득별세부사항> 근로소득별세부사항 { get; set; }
    }
}
