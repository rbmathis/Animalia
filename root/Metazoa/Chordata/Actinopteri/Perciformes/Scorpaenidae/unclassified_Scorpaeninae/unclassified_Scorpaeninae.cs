using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Scorpaenidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Scorpaenidae.unclassified_Scorpaeninae;

/// <summary>
/// Abstract class for unclassified Scorpaeninae (no rank).
/// NCBI TaxId: 2554915
/// </summary>
public abstract class unclassified_Scorpaeninae : Scorpaenidae, Iunclassified_Scorpaeninae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Scorpaeninae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2554915;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Scorpaeninae";
}
