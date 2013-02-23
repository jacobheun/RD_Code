using UnityEditor;

namespace RealDedicated_UnityEditorLibrary
{
    public class AudioImportSettings : AssetPostprocessor
    {
        public void OnPreprocessAudio()
        {
            AudioImporter importer = this.assetImporter as AudioImporter;

            if (importer.assetPath.Contains("Music"))
                importer.threeD = false;
        }
    }
}
