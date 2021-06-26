//----------------------------------------------------------------------------
//  This file is automatically generated, do not modify.      
//----------------------------------------------------------------------------



using System;
using System.Runtime.InteropServices;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.Util;

namespace Emgu.CV
{
   public static partial class CvInvoke
   {

     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)] 
     internal static extern int cveDISOpticalFlowGetFinestScale(IntPtr obj);
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
     internal static extern void cveDISOpticalFlowSetFinestScale(
        IntPtr obj,  
        int val);
     
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)] 
     internal static extern int cveDISOpticalFlowGetPatchSize(IntPtr obj);
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
     internal static extern void cveDISOpticalFlowSetPatchSize(
        IntPtr obj,  
        int val);
     
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)] 
     internal static extern int cveDISOpticalFlowGetPatchStride(IntPtr obj);
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
     internal static extern void cveDISOpticalFlowSetPatchStride(
        IntPtr obj,  
        int val);
     
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)] 
     internal static extern int cveDISOpticalFlowGetGradientDescentIterations(IntPtr obj);
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
     internal static extern void cveDISOpticalFlowSetGradientDescentIterations(
        IntPtr obj,  
        int val);
     
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)] 
     internal static extern int cveDISOpticalFlowGetVariationalRefinementIterations(IntPtr obj);
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
     internal static extern void cveDISOpticalFlowSetVariationalRefinementIterations(
        IntPtr obj,  
        int val);
     
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)] 
     internal static extern float cveDISOpticalFlowGetVariationalRefinementAlpha(IntPtr obj);
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
     internal static extern void cveDISOpticalFlowSetVariationalRefinementAlpha(
        IntPtr obj,  
        float val);
     
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)] 
     internal static extern float cveDISOpticalFlowGetVariationalRefinementDelta(IntPtr obj);
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
     internal static extern void cveDISOpticalFlowSetVariationalRefinementDelta(
        IntPtr obj,  
        float val);
     
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)] 
     internal static extern float cveDISOpticalFlowGetVariationalRefinementGamma(IntPtr obj);
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
     internal static extern void cveDISOpticalFlowSetVariationalRefinementGamma(
        IntPtr obj,  
        float val);
     
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)] 
     [return: MarshalAs(CvInvoke.BoolMarshalType)]
     internal static extern bool cveDISOpticalFlowGetUseMeanNormalization(IntPtr obj);
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
     internal static extern void cveDISOpticalFlowSetUseMeanNormalization(
        IntPtr obj, 
        [MarshalAs(CvInvoke.BoolMarshalType)] 
        bool val);
     
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)] 
     [return: MarshalAs(CvInvoke.BoolMarshalType)]
     internal static extern bool cveDISOpticalFlowGetUseSpatialPropagation(IntPtr obj);
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
     internal static extern void cveDISOpticalFlowSetUseSpatialPropagation(
        IntPtr obj, 
        [MarshalAs(CvInvoke.BoolMarshalType)] 
        bool val);
     
   }

   public partial class DISOpticalFlow
   {

     /// <summary>
     /// Finest level of the Gaussian pyramid on which the flow is computed (zero level corresponds to the original image resolution). The final flow is obtained by bilinear upscaling.
     /// </summary>
     public int FinestScale
     {
        get { return CvInvoke.cveDISOpticalFlowGetFinestScale(_ptr); } 
        set { CvInvoke.cveDISOpticalFlowSetFinestScale(_ptr, value); }
     }
     
     /// <summary>
     /// Size of an image patch for matching (in pixels). Normally, default 8x8 patches work well enough in most cases.
     /// </summary>
     public int PatchSize
     {
        get { return CvInvoke.cveDISOpticalFlowGetPatchSize(_ptr); } 
        set { CvInvoke.cveDISOpticalFlowSetPatchSize(_ptr, value); }
     }
     
     /// <summary>
     /// Stride between neighbor patches. Must be less than patch size. Lower values correspond to higher flow quality.
     /// </summary>
     public int PatchStride
     {
        get { return CvInvoke.cveDISOpticalFlowGetPatchStride(_ptr); } 
        set { CvInvoke.cveDISOpticalFlowSetPatchStride(_ptr, value); }
     }
     
     /// <summary>
     /// Maximum number of gradient descent iterations in the patch inverse search stage. Higher values may improve quality in some cases.
     /// </summary>
     public int GradientDescentIterations
     {
        get { return CvInvoke.cveDISOpticalFlowGetGradientDescentIterations(_ptr); } 
        set { CvInvoke.cveDISOpticalFlowSetGradientDescentIterations(_ptr, value); }
     }
     
     /// <summary>
     /// Number of fixed point iterations of variational refinement per scale. Set to zero to disable variational refinement completely. Higher values will typically result in more smooth and high-quality flow.
     /// </summary>
     public int VariationalRefinementIterations
     {
        get { return CvInvoke.cveDISOpticalFlowGetVariationalRefinementIterations(_ptr); } 
        set { CvInvoke.cveDISOpticalFlowSetVariationalRefinementIterations(_ptr, value); }
     }
     
     /// <summary>
     /// Weight of the smoothness term
     /// </summary>
     public float VariationalRefinementAlpha
     {
        get { return CvInvoke.cveDISOpticalFlowGetVariationalRefinementAlpha(_ptr); } 
        set { CvInvoke.cveDISOpticalFlowSetVariationalRefinementAlpha(_ptr, value); }
     }
     
     /// <summary>
     /// Weight of the color constancy term
     /// </summary>
     public float VariationalRefinementDelta
     {
        get { return CvInvoke.cveDISOpticalFlowGetVariationalRefinementDelta(_ptr); } 
        set { CvInvoke.cveDISOpticalFlowSetVariationalRefinementDelta(_ptr, value); }
     }
     
     /// <summary>
     /// Weight of the gradient constancy term
     /// </summary>
     public float VariationalRefinementGamma
     {
        get { return CvInvoke.cveDISOpticalFlowGetVariationalRefinementGamma(_ptr); } 
        set { CvInvoke.cveDISOpticalFlowSetVariationalRefinementGamma(_ptr, value); }
     }
     
     /// <summary>
     /// Whether to use mean-normalization of patches when computing patch distance. It is turned on by default as it typically provides a noticeable quality boost because of increased robustness to illumination variations. Turn it off if you are certain that your sequence doesn't contain any changes in illumination.
     /// </summary>
     public bool UseMeanNormalization
     {
        get { return CvInvoke.cveDISOpticalFlowGetUseMeanNormalization(_ptr); } 
        set { CvInvoke.cveDISOpticalFlowSetUseMeanNormalization(_ptr, value); }
     }
     
     /// <summary>
     /// Whether to use spatial propagation of good optical flow vectors. This option is turned on by default, as it tends to work better on average and can sometimes help recover from major errors introduced by the coarse-to-fine scheme employed by the DIS optical flow algorithm. Turning this option off can make the output flow field a bit smoother, however.
     /// </summary>
     public bool UseSpatialPropagation
     {
        get { return CvInvoke.cveDISOpticalFlowGetUseSpatialPropagation(_ptr); } 
        set { CvInvoke.cveDISOpticalFlowSetUseSpatialPropagation(_ptr, value); }
     }
     
   }
}
