using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Hoplophryne;

/// <summary>
/// Abstract class for Hoplophryne (genus).
/// NCBI TaxId: 274520
/// </summary>
public abstract class Hoplophryne : Microhylidae, IHoplophryne
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hoplophryne";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 274520;

    /// <inheritdoc />
    public virtual string GenusName => "Hoplophryne";

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
