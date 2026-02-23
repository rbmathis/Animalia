using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Malaconotidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Malaconotidae.Nilaus;

/// <summary>
/// Abstract class for Nilaus (genus).
/// NCBI TaxId: 272838
/// </summary>
public abstract class Nilaus : Malaconotidae, INilaus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nilaus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 272838;

    /// <inheritdoc />
    public virtual string GenusName => "Nilaus";

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
