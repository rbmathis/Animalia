using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Scorpaenidae.Scorpaenopsis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Scorpaenidae.Scorpaenopsis.unclassified_Scorpaenopsis;

/// <summary>
/// Abstract class for unclassified Scorpaenopsis (no rank).
/// NCBI TaxId: 2636404
/// </summary>
public abstract class unclassified_Scorpaenopsis : Scorpaenopsis, Iunclassified_Scorpaenopsis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Scorpaenopsis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2636404;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Scorpaenopsis";
}
