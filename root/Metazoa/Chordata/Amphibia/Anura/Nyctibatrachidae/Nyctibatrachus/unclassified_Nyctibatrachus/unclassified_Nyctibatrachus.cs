using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Nyctibatrachidae.Nyctibatrachus;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Nyctibatrachidae.Nyctibatrachus.unclassified_Nyctibatrachus;

/// <summary>
/// Abstract class for unclassified Nyctibatrachus (no rank).
/// NCBI TaxId: 2649565
/// </summary>
public abstract class unclassified_Nyctibatrachus : Nyctibatrachus, Iunclassified_Nyctibatrachus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Nyctibatrachus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2649565;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Nyctibatrachus";
}
