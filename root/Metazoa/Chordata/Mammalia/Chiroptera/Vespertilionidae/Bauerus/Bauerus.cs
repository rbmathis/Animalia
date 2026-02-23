using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Bauerus;

/// <summary>
/// Abstract class for Bauerus (genus).
/// NCBI TaxId: 3135596
/// </summary>
public abstract class Bauerus : Vespertilionidae, IBauerus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bauerus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3135596;

    /// <inheritdoc />
    public virtual string GenusName => "Bauerus";

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
