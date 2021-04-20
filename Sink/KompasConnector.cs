using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Sink;
using KAPITypes;
using Kompas6Constants;
using Kompas6Constants3D;
using Kompas6API5;
using KompasAPI7;

namespace Sink
{
    public class KompasConnector
    {
        /// <summary>
        /// Интерфейс API КОМПАС 3D.
        /// </summary>
        public KompasObject KompasObj { get; set; }

        /// <summary>
        /// Документ 3D
        /// </summary>
        public ksDocument3D Document3D { get; set; }

        /// <summary>
        /// Сборка
        /// </summary>
        public ksPart KsPart { get; set; }

        /// <summary>
        /// Открытие компаса
        /// </summary>
        public void OpenKOMPAS()
        {
            try
            {
                Type t = Type.GetTypeFromProgID("KOMPAS.Application.5");
                KompasObj = (KompasObject)Activator.CreateInstance(t);

            }
            catch
            {
                KompasObj = null;
                Type t = Type.GetTypeFromProgID("KOMPAS.Application.5");
                KompasObj = (KompasObject)Activator.CreateInstance(t);
            }
            KompasObj.Visible = true;
            KompasObj.ActivateControllerAPI();
        }
    }
}