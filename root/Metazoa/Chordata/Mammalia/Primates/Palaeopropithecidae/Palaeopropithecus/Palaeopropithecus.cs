using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Palaeopropithecidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Palaeopropithecidae.Palaeopropithecus;

/// <summary>
/// Abstract class for Palaeopropithecus (genus).
/// NCBI TaxId: 322024
/// </summary>
public abstract class Palaeopropithecus : Palaeopropithecidae, IPalaeopropithecus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Palaeopropithecus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 322024;

    /// <inheritdoc />
    public virtual string GenusName => "Palaeopropithecus";

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
