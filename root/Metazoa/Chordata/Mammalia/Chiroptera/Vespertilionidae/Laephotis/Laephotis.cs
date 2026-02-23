using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Laephotis;

/// <summary>
/// Abstract class for Laephotis (genus).
/// NCBI TaxId: 258926
/// </summary>
public abstract class Laephotis : Vespertilionidae, ILaephotis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Laephotis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 258926;

    /// <inheritdoc />
    public virtual string GenusName => "Laephotis";

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
