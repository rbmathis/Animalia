using AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Rostratulidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Rostratulidae.Nycticryphes;

/// <summary>
/// Abstract class for Nycticryphes (genus).
/// NCBI TaxId: 227225
/// </summary>
public abstract class Nycticryphes : Rostratulidae, INycticryphes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nycticryphes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 227225;

    /// <inheritdoc />
    public virtual string GenusName => "Nycticryphes";

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
