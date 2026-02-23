using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Arcovomer;

/// <summary>
/// Abstract class for Arcovomer (genus).
/// NCBI TaxId: 1138476
/// </summary>
public abstract class Arcovomer : Microhylidae, IArcovomer
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Arcovomer";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1138476;

    /// <inheritdoc />
    public virtual string GenusName => "Arcovomer";

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
