using AnimalKingdom.root.Metazoa.Chordata.Aves.Nyctibiiformes.Nyctibiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Nyctibiiformes.Nyctibiidae.Nyctibius;

/// <summary>
/// Abstract class for Nyctibius (genus).
/// NCBI TaxId: 48424
/// </summary>
public abstract class Nyctibius : Nyctibiidae, INyctibius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nyctibius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 48424;

    /// <inheritdoc />
    public virtual string GenusName => "Nyctibius";

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
