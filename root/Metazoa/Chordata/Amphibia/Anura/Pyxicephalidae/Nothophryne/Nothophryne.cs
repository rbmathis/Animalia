using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pyxicephalidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pyxicephalidae.Nothophryne;

/// <summary>
/// Abstract class for Nothophryne (genus).
/// NCBI TaxId: 685132
/// </summary>
public abstract class Nothophryne : Pyxicephalidae, INothophryne
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nothophryne";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 685132;

    /// <inheritdoc />
    public virtual string GenusName => "Nothophryne";

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
