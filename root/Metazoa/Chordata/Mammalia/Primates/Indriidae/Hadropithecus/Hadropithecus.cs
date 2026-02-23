using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Indriidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Indriidae.Hadropithecus;

/// <summary>
/// Abstract class for Hadropithecus (genus).
/// NCBI TaxId: 523824
/// </summary>
public abstract class Hadropithecus : Indriidae, IHadropithecus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hadropithecus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 523824;

    /// <inheritdoc />
    public virtual string GenusName => "Hadropithecus";

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
