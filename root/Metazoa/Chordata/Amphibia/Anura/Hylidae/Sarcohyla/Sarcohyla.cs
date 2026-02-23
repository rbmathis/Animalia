using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Sarcohyla;

/// <summary>
/// Abstract class for Sarcohyla (genus).
/// NCBI TaxId: 1905811
/// </summary>
public abstract class Sarcohyla : Hylidae, ISarcohyla
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sarcohyla";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1905811;

    /// <inheritdoc />
    public virtual string GenusName => "Sarcohyla";

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
