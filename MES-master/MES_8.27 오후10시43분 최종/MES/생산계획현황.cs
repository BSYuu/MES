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
    
    public partial class 생산계획현황
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public 생산계획현황()
        {
            this.작업지시현황 = new HashSet<작업지시현황>();
        }
    
        public string 생산계획현황번호 { get; set; }
        public System.DateTime 작업예정일 { get; set; }
        public System.DateTime 작업확정일 { get; set; }
        public int 수량 { get; set; }
        public string 제품번호 { get; set; }
    
        public virtual 제품 제품 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<작업지시현황> 작업지시현황 { get; set; }
    }
}
