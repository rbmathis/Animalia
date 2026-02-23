using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Lepilemuridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Lepilemuridae.Megaladapis;

/// <summary>
/// Abstract class for Megaladapis (genus).
/// NCBI TaxId: 126593
/// </summary>
public abstract class Megaladapis : Lepilemuridae, IMegaladapis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Megaladapis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 126593;

    /// <inheritdoc />
    public virtual string GenusName => "Megaladapis";

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
