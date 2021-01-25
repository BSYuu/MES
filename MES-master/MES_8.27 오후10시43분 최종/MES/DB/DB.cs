using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES
{
    public class DB
    {
        public static MES투입현황Data MES투입현황 { get; } = new MES투입현황Data();
        public static MES현장실적현황Data MES현장실적현황 { get; } = new MES현장실적현황Data();
        public static 작업지시현황Data 작업지시현황 { get; } = new 작업지시현황Data();
        public static 제품Data 제품 { get; } = new 제품Data();
        public static 공정Data 공정 { get; } = new 공정Data();
        public static 생산계획Data 생산계획 { get; } = new 생산계획Data();
        public static 자재명세서Data 자재명세서 { get; } = new 자재명세서Data();
        public static 불량상세정보Data 불량상세정보 { get; } = new 불량상세정보Data();
        public static 품목정보Data 품목정보 { get; } = new 품목정보Data();
        public static 수주Data 수주 { get; } = new 수주Data();
        public static MES불량실적현황Data MES불량실적현황 { get; } = new MES불량실적현황Data();
        public static MES공정별수량Data MES공정별수량 { get; } = new MES공정별수량Data();
        public static 사원등록Data 사원등록 { get; } = new 사원등록Data();
    }
}
