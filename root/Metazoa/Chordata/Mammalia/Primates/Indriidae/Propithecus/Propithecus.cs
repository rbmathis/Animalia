using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Indriidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Indriidae.Propithecus;

/// <summary>
/// Abstract class for Propithecus (genus).
/// NCBI TaxId: 30600
/// </summary>
public abstract class Propithecus : Indriidae, IPropithecus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Propithecus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 30600;

    /// <inheritdoc />
    public virtual string GenusName => "Propithecus";

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
