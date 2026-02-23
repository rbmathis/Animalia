using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Mantophryne;

/// <summary>
/// Abstract class for Mantophryne (genus).
/// NCBI TaxId: 512496
/// </summary>
public abstract class Mantophryne : Microhylidae, IMantophryne
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mantophryne";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 512496;

    /// <inheritdoc />
    public virtual string GenusName => "Mantophryne";

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
