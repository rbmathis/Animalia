using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Hominidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Hominidae.Homo;

/// <summary>
/// Abstract class for Homo (genus).
/// NCBI TaxId: 9605
/// </summary>
public abstract class Homo : Hominidae, IHomo
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Homo";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9605;

    /// <inheritdoc />
    public virtual string GenusName => "Homo";

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
