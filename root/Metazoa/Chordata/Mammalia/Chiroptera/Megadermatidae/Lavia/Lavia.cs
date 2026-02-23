using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Megadermatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Megadermatidae.Lavia;

/// <summary>
/// Abstract class for Lavia (genus).
/// NCBI TaxId: 1582324
/// </summary>
public abstract class Lavia : Megadermatidae, ILavia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lavia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1582324;

    /// <inheritdoc />
    public virtual string GenusName => "Lavia";

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
