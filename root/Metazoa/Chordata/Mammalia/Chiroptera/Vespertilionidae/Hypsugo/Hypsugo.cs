using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Hypsugo;

/// <summary>
/// Abstract class for Hypsugo (genus).
/// NCBI TaxId: 109484
/// </summary>
public abstract class Hypsugo : Vespertilionidae, IHypsugo
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hypsugo";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 109484;

    /// <inheritdoc />
    public virtual string GenusName => "Hypsugo";

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
