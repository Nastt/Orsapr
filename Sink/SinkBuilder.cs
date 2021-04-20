using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sink;
using KAPITypes;
using Kompas6Constants;
using Kompas6Constants3D;
using Kompas6API5;
using KompasAPI7;
using reference = System.Int32;
using Microsoft.Win32;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Sink
{
    public class SinkBuilder
    {

        /// <summary>
        /// Указатель на интерфейс элемента модели
        /// </summary>
        private ksEntity _entity;

        /// <summary>
        /// Указатель на интерфейс эскиза
        /// </summary>
        private ksSketchDefinition _sketch;

        /// <summary>
        /// Указатель на графический документ
        /// </summary>
        private ksDocument2D _doc2D;

        /// <summary>
        /// Конструктор класса DeskDrawerBuilder
        /// </summary>
        /// <param name="kompas3D">Экземпляр Компас-3D</param>
        public SinkBuild(KompasObject kompas3D)
        {
            KompasObj = kompas3D;
        }

        /// <summary>
        /// Создание объекта
        /// </summary>
        /// <param name="parameters">Размеры объекта</param>
        public void BuildObject(SinkParameter parameters)
        {
            Document3D = (ksDocument3D)KompasObj.Document3D();
            Document3D.Create();
            Document3D = (ksDocument3D)KompasObj.ActiveDocument3D();
            KsPart = (ksPart)Document3D.GetPart((short)Part_Type.pTop_Part);
            //TODO: RSDN
            CreateFrontWall(parameters.SinkWidth, parameters.SinkLength);

            (new SinkBuild()).BuildObject(parameters);
            // CreateInnerPart(parameters.LengthSidewalls, parameters.HeightInnerWalls, parameters.LengthBackWall,
            //  parameters.WidthSidewalls, parameters.LengthFrontWall, parameters.WidthFrontWall, parameters.WidthBackWall);
        }

        /// <summary>
        /// Создать эскиз
        /// </summary>
        /// <param name="currentPlane">Плоскость, на которой будет создан эскиз</param>
        private void CreateSketch(ksEntity currentPlane)
        {
            _entity = (ksEntity)KsPart.NewEntity((short)Obj3dType.o3d_sketch);
            _sketch = (ksSketchDefinition)_entity.GetDefinition();
            _sketch.SetPlane(currentPlane);
            _entity.Create();
        }

        private void CreateFrontWall(double sinkWidth, double sinkLength)
        {
            var currentPlane = (ksEntity)KsPart.GetDefaultEntity((short)Obj3dType.o3d_planeXOY);
            BuildSinkBasis(sinkWidth, sinkLength, 0, 0, currentPlane);
        }

        /// <summary>
        /// Нарисовать прямоугольник
        /// </summary>
        /// <param name="height">Высота прямоугольника</param>
        /// <param name="width">Ширина прямоугольника</param>
        /// <param name="x">Координата базовой точки x пря­моугольника</param>
        /// <param name="y">координата базовой точки y пря­моугольника</param>
        /// <param name="currentPlane">Плоскость на которой рисуется прямоугольник</param>
        private void BuildSinkBasis(double width, double height, double x, double y, ksEntity currentPlane)
        {

            CreateSketch(currentPlane);
            _doc2D = (ksDocument2D)_sketch.BeginEdit();
            //TODO: RSDN
            var rectangleParam = (ksRectangleParam)KompasObj.GetParamStruct((short)StructType2DEnum.ko_RectangleParam);
            rectangleParam.ang = 0;
            rectangleParam.height = height;
            rectangleParam.width = width;
            rectangleParam.style = 1;
            rectangleParam.x = x;
            rectangleParam.y = y;
            _doc2D.ksRectangle(rectangleParam);
            _sketch.EndEdit();
        }

        //  double SinkWidth;
        /* public void BuildSinkModel(ksPart ksPart, SinkParameter parameters)
         {
             //построение основы сверла

            BuildSinkBasis();
             //построение лапки
         }*/



        /*/// <summary>
        /// Функция построения основы мойки
        /// </summary>
        /// <param name="ksPart">интерфейс модели</param>
        /// <param name="parameters">параметры моодели</param>
       /* private void BuildDrillBase(ksPart ksPart, SinkParameter parameters)
        {
            ksEntity sketchDrillBase = (ksEntity) ksPart.NewEntity((short) Obj3dType.o3d_SketchRadialDimension);
           ksSketchDefinition definitionSketch = (ksSketchDefinition) sketchDrillBase.GetDefinition();
           ksEntity constructionPlane = (ksEntity) ksPart.GetDefaultEntity((short) Obj3dType.o3d_planeXOZ);

        }*/
    }
}