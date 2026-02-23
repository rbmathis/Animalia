using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Hylobatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Hylobatidae.Hoolock;

/// <summary>
/// Abstract class for Hoolock (genus).
/// NCBI TaxId: 325167
/// </summary>
public abstract class Hoolock : Hylobatidae, IHoolock
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hoolock";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 325167;

    /// <inheritdoc />
    public virtual string GenusName => "Hoolock";

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
