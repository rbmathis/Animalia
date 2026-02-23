using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Rhinolophidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Rhinolophidae.Rhinolophus;

/// <summary>
/// Abstract class for Rhinolophus (genus).
/// NCBI TaxId: 49442
/// </summary>
public abstract class Rhinolophus : Rhinolophidae, IRhinolophus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rhinolophus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 49442;

    /// <inheritdoc />
    public virtual string GenusName => "Rhinolophus";

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
