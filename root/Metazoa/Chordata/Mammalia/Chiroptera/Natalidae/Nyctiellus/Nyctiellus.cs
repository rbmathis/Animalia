using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Natalidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Natalidae.Nyctiellus;

/// <summary>
/// Abstract class for Nyctiellus (genus).
/// NCBI TaxId: 290565
/// </summary>
public abstract class Nyctiellus : Natalidae, INyctiellus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nyctiellus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 290565;

    /// <inheritdoc />
    public virtual string GenusName => "Nyctiellus";

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
