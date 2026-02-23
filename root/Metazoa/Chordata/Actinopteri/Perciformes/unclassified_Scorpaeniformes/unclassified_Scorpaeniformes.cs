using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.unclassified_Scorpaeniformes;

/// <summary>
/// Abstract class for unclassified Scorpaeniformes (no rank).
/// NCBI TaxId: 723964
/// </summary>
public abstract class unclassified_Scorpaeniformes : Perciformes, Iunclassified_Scorpaeniformes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Scorpaeniformes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 723964;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Scorpaeniformes";
}
