using AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Cracidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Cracidae.Chamaepetes;

/// <summary>
/// Abstract class for Chamaepetes (genus).
/// NCBI TaxId: 125059
/// </summary>
public abstract class Chamaepetes : Cracidae, IChamaepetes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chamaepetes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 125059;

    /// <inheritdoc />
    public virtual string GenusName => "Chamaepetes";

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
