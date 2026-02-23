using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Scorpaenidae.Scorpaenodes;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Scorpaenidae.Scorpaenodes.unclassified_Scorpaenodes;

/// <summary>
/// Abstract class for unclassified Scorpaenodes (no rank).
/// NCBI TaxId: 2645454
/// </summary>
public abstract class unclassified_Scorpaenodes : Scorpaenodes, Iunclassified_Scorpaenodes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Scorpaenodes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2645454;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Scorpaenodes";
}
