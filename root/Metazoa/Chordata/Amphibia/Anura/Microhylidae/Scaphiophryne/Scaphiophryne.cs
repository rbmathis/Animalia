using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Scaphiophryne;

/// <summary>
/// Abstract class for Scaphiophryne (genus).
/// NCBI TaxId: 68437
/// </summary>
public abstract class Scaphiophryne : Microhylidae, IScaphiophryne
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Scaphiophryne";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 68437;

    /// <inheritdoc />
    public virtual string GenusName => "Scaphiophryne";

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
