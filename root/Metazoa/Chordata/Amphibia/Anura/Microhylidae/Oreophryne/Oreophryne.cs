using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Oreophryne;

/// <summary>
/// Abstract class for Oreophryne (genus).
/// NCBI TaxId: 83978
/// </summary>
public abstract class Oreophryne : Microhylidae, IOreophryne
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Oreophryne";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 83978;

    /// <inheritdoc />
    public virtual string GenusName => "Oreophryne";

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
