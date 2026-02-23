using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Aphantophryne;

/// <summary>
/// Abstract class for Aphantophryne (genus).
/// NCBI TaxId: 356258
/// </summary>
public abstract class Aphantophryne : Microhylidae, IAphantophryne
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Aphantophryne";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 356258;

    /// <inheritdoc />
    public virtual string GenusName => "Aphantophryne";

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
