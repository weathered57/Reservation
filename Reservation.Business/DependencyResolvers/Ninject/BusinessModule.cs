using Ninject.Modules;
using Reservation.Business.Abstract;
using Reservation.Business.Concrete;
using Reservation.DataAccess.Abstract;
using Reservation.DataAccess.Concrete.EntityFramewrok;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation.Business.DependencyResolvers.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IFoodReservationService>().To<FoodReservationManager>().InSingletonScope();
            Bind<IStudentService>().To<StudentManager>().InSingletonScope();
            Bind<IBreakfastService>().To<BreakfastManager>().InSingletonScope();
            Bind<IDinnerService>().To<DinnerManager>().InSingletonScope();
            Bind<ILunchService>().To<LunchManager>().InSingletonScope();
            Bind<ISaloonService>().To<SaloonManager>().InSingletonScope();

            Bind<IFoodReservationDal>().To<EfFoodReservationDal>().InSingletonScope();
            Bind<IStudentDal>().To<EfStudentDal>().InSingletonScope();
            Bind<IBreakfastDal>().To<EfBreakfastDal>().InSingletonScope();
            Bind<IDinnerDal>().To<EfDinnerDal>().InSingletonScope();
            Bind<ILunchDal>().To<EfLunchDal>().InSingletonScope();
            Bind<ISaloonDal>().To<EfSaloonDal>().InSingletonScope();
        }
    }
}
