using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Tetraodontidae.Takifugu;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Tetraodontidae.Takifugu.unclassified_Takifugu;

/// <summary>
/// Abstract class for unclassified Takifugu (no rank).
/// NCBI TaxId: 2644519
/// </summary>
public abstract class unclassified_Takifugu : Takifugu, Iunclassified_Takifugu
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Takifugu";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2644519;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Takifugu";
}
