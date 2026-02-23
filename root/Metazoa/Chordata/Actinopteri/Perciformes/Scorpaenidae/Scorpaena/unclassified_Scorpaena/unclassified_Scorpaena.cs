using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Scorpaenidae.Scorpaena;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Scorpaenidae.Scorpaena.unclassified_Scorpaena;

/// <summary>
/// Abstract class for unclassified Scorpaena (no rank).
/// NCBI TaxId: 2631569
/// </summary>
public abstract class unclassified_Scorpaena : Scorpaena, Iunclassified_Scorpaena
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Scorpaena";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2631569;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Scorpaena";
}
