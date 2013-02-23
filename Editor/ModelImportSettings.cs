using System.Collections;
using UnityEditor;

namespace RealDedicated_UnityEditorLibrary
{
    public class ModelImportSettings : AssetPostprocessor
    {
        public bool importMaterials = false;
        public bool generateLightmapUVs = true;
        public bool importAnimations = false;

        public void OnPreprocessModel()
        {
            ModelImporter importer = this.assetImporter as ModelImporter;

            if (!this.importMaterials)
                importer.generateMaterials = ModelImporterGenerateMaterials.None;

            if (this.generateLightmapUVs)
                importer.generateSecondaryUV = true;
        }
    }
}
