using AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Malacorhynchus;

/// <summary>
/// Abstract class for Malacorhynchus (genus).
/// NCBI TaxId: 45645
/// </summary>
public abstract class Malacorhynchus : Anatidae, IMalacorhynchus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Malacorhynchus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 45645;

    /// <inheritdoc />
    public virtual string GenusName => "Malacorhynchus";

    /// <inheritdoc />
    public virtual string[] GenusCharacteristics => new[]
    {
        "Large body size",
        "Social pack structure",
        "Complex hunting strategies",
        "Highly developed olfaction",
        "Territorial behavior"
    };

    /// <inheritdoc />
    public virtual bool CanInterbreed => true;

}
