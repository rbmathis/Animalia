using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Scorpaenidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Scorpaenidae.unclassified_Scorpaenidae;

/// <summary>
/// Abstract class for unclassified Scorpaenidae (no rank).
/// NCBI TaxId: 722524
/// </summary>
public abstract class unclassified_Scorpaenidae : Scorpaenidae, Iunclassified_Scorpaenidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Scorpaenidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 722524;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Scorpaenidae";
}
