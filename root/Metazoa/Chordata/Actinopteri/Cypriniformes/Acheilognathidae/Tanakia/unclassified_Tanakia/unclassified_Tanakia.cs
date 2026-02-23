using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Acheilognathidae.Tanakia;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Acheilognathidae.Tanakia.unclassified_Tanakia;

/// <summary>
/// Abstract class for unclassified Tanakia (no rank).
/// NCBI TaxId: 2629114
/// </summary>
public abstract class unclassified_Tanakia : Tanakia, Iunclassified_Tanakia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Tanakia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2629114;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Tanakia";
}
