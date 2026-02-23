using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Pholidota.Manidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Pholidota.Manidae.Phataginus;

/// <summary>
/// Abstract class for Phataginus (genus).
/// NCBI TaxId: 2736678
/// </summary>
public abstract class Phataginus : Manidae, IPhataginus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Phataginus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2736678;

    /// <inheritdoc />
    public virtual string GenusName => "Phataginus";

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
