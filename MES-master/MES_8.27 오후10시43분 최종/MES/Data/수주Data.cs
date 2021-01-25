using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES
{
    public class 수주Data : EntityData<수주>
    {
        public List<공정시작수량Data> Get공정시작수량()
        {
            using (ERPEntities context = new ERPEntities())
            {
                List<수주현황> 수주현황List = new List<수주현황>();

                var 수주q = (from h in context.수주
                           group h by new { h.제품번호, h.납기일 } into hh
                           orderby hh.Key
                           //where hh.Key.제품번호 == 제품번호
                           select new
                           {
                               hh.Key.제품번호,
                               hh.Key.납기일,
                               주문수량 = hh.Sum(s => s.주문수량),
                           }).OrderBy(o => o.납기일);

                var 품번 = 수주q.Select(x => x.제품번호).Distinct();

                var 제품q = (from a in context.제품
                           select new
                           {
                               a.제품번호,
                               a.재고량,
                               a.안전재고량,
                               a.리드타임,
                               a.LOT수량
                           });

                var 제품s = 제품q.Where(x => 품번.Contains(x.제품번호)).ToList();

                List<공정시작수량Data> 공정시작수량list = new List<공정시작수량Data>();

                foreach (var 제품item in 제품s)
                {

                    int _1차필요수량 = 0;
                    int _2차필요수량 = 0;
                    int LOT수량 = 0;
                    string 제품번호 = null;
                    DateTime _1차공정시작날짜 = new DateTime();
                    DateTime _2차공정시작날짜 = new DateTime();
                    Boolean _1차공정시작 = false;
                    Boolean _2차공정시작 = false;

                    _1차필요수량 = 제품item.안전재고량 - 제품item.재고량;
                    LOT수량 = 제품item.LOT수량;
                    제품번호 = 제품item.제품번호;

                    foreach (var 수주item in 수주q)
                    {
                        if (수주item.제품번호 == 제품번호)
                        {
                            _1차필요수량 += 수주item.주문수량;

                            if ((_1차필요수량 > 0) && (_1차공정시작 == false))
                            {
                                _1차공정시작 = true;
                                _1차공정시작날짜 = 수주item.납기일;
                            }


                            if (_1차필요수량 > LOT수량 && _2차공정시작 == false)
                            {
                                _2차공정시작 = true;
                                _2차공정시작날짜 = 수주item.납기일;
                                _2차필요수량 = _1차필요수량 - LOT수량;
                                _1차필요수량 = LOT수량;
                            }
                            else if (_2차공정시작 == true)
                            {
                                _2차필요수량 += 수주item.주문수량;
                            }


                            if (_2차필요수량 > LOT수량)
                            {
                                break;
                            }

                            if (_1차공정시작 == false)
                            {
                                //수주item.납기일 = (DateTime)null;
                            }
                        }
                    }
                    if (_1차공정시작 == true)
                    {

                        공정시작수량Data 공정시작수량c = new 공정시작수량Data
                        {
                            제품번호 = 제품번호,
                            _1차공정시작 = _1차공정시작,
                            //_1차관리번호 = 
                            _1차필요수량 = _1차필요수량,
                            _1차공정시작날짜 = DateTime.Parse(_1차공정시작날짜.ToShortDateString()),
                            _2차공정시작 = _2차공정시작,
                            //_2차관리번호 =
                            _2차필요수량 = _2차필요수량,
                            _2차공정시작날짜 = DateTime.Parse(_2차공정시작날짜.ToShortDateString()),
                            LOT수량 = LOT수량
                        };

                        공정시작수량list.Add(공정시작수량c);
                    }
                }

                List<공정시작수량Data> 공정시작수량list_2 = new List<공정시작수량Data>();
                공정시작수량list_2 = 공정시작수량list.OrderBy(x => x._1차공정시작날짜).ToList();



                //foreach (var item in 수주q)
                //{
                //    수주현황 수주현황c = new 수주현황()
                //    {
                //        납기일 = item.납기일,
                //        제품번호 = item.제품번호,
                //        주문수량 = item.주문수량
                //    };

                //    수주현황List.Add(수주현황c);
                //}

                int 순위cnt = 1;

                공정시작수량list_2[0].순위 = 1;

                for (int i = 0; i < 공정시작수량list_2.Count() - 1; i++)
                {
                    if (공정시작수량list_2[i + 1]._1차공정시작날짜 == null)
                    {
                        break;
                    }

                    if (공정시작수량list_2[i]._1차공정시작날짜 != 공정시작수량list_2[i + 1]._1차공정시작날짜)
                    {
                        순위cnt++;
                    }

                    공정시작수량list_2[i + 1].순위 = 순위cnt;
                }


                return 공정시작수량list_2;


                //foreach (var item in 수주q)
                //{
                //    수주현황 items = new 수주현황()
                //    {
                //        납기일 = item.납기일,
                //        품번 = item.제품번호,
                //        수량 = item.주문수량
                //    };

                //    수주현황List.Add(items);
                //}



                //var 제품q = from a in context.제품
                //         // where a.제품번호 == 제품번호
                //          select new
                //          {
                //              a.재고량,
                //              a.안전재고량,
                //              a.리드타임,
                //              a.LOT수량
                //          };

                //int _1차필요수량 = 0;
                //int _2차필요수량 = 0;
                //int LOT수량 = 0;
                //DateTime _1차공정시작날짜 = new DateTime();
                //DateTime _2차공정시작날짜 = new DateTime();
                //Boolean _1차공정시작 = false;
                //Boolean _2차공정시작 = false;

                //foreach (var 제품item in 제품q)
                //{
                //    _1차필요수량 = 제품item.안전재고량 - 제품item.재고량;
                //    LOT수량 = 제품item.LOT수량;

                //    foreach (var 수주item in 수주q)
                //    {
                //        if ((_1차필요수량 > 0) && (_1차공정시작 == false))
                //        {
                //            _1차공정시작 = true;
                //            _1차공정시작날짜 = 수주item.납기일.AddDays(-제품item.리드타임);
                //        }

                //        _1차필요수량 += 수주item.주문수량;

                //        if((_1차필요수량 >= 제품item.LOT수량 - 제품item.안전재고량 + 제품item.재고량)  && (_2차공정시작 == false) && (_1차공정시작 == true))
                //        {
                //            _2차공정시작 = true;
                //            _2차공정시작날짜 = 수주item.납기일.AddDays(-제품item.리드타임);
                //        }
                //    }

                //    if (_2차공정시작 == true)
                //    {
                //        _2차필요수량 = _1차필요수량 - 제품item.LOT수량;
                //        _1차필요수량 = 제품item.LOT수량;
                //    }
                //}

                ////string _1차관리번호 = $"{_1차공정시작날짜.ToString()}{001}";
                ////string _2차관리번호 = $"{_2차공정시작날짜.ToString()}{001}";

                ////공정시작수량Data 공정시작수량c = new 공정시작수량Data
                ////{

                ////    제품번호 = 제품번호,
                ////    _1차공정시작 = _1차공정시작,
                ////    //_1차관리번호 = 
                ////    _1차필요수량 = _1차필요수량,
                ////    _1차공정시작날짜 = _1차공정시작날짜,

                ////    _2차공정시작 = _2차공정시작,
                ////    //_2차관리번호 =
                ////    _2차필요수량 = _2차필요수량,
                ////    _2차공정시작날짜 = _2차공정시작날짜,
                ////    LOT수량 = LOT수량

                ////};

                ////return 공정시작수량c;

                ////제품번호, 1차공정시작, 1차필요수량, 1차공정시작날짜, 2차공정시작, 2차필요수량, 2차공정시작날짜, LOT수량
                ////string, boolean, int, DateTime, boolean, int, DateTime, int

            }
        }
    }
}
