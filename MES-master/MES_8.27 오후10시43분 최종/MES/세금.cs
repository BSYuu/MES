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
    
    public partial class 세금
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public 세금()
        {
            this.급여 = new HashSet<급여>();
        }
    
        public string 세금코드 { get; set; }
        public int 국민연금 { get; set; }
        public int 건강보험 { get; set; }
        public int 산재보험 { get; set; }
        public int 고용보험 { get; set; }
        public int 지방소득세 { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<급여> 급여 { get; set; }
    }
}
