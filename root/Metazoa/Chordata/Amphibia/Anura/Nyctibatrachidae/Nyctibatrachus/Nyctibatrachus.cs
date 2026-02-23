using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Nyctibatrachidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Nyctibatrachidae.Nyctibatrachus;

/// <summary>
/// Abstract class for Nyctibatrachus (genus).
/// NCBI TaxId: 129020
/// </summary>
public abstract class Nyctibatrachus : Nyctibatrachidae, INyctibatrachus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nyctibatrachus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 129020;

    /// <inheritdoc />
    public virtual string GenusName => "Nyctibatrachus";

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
