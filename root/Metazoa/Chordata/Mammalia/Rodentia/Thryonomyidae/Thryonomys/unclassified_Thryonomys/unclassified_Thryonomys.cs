using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Thryonomyidae.Thryonomys;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Thryonomyidae.Thryonomys.unclassified_Thryonomys;

/// <summary>
/// Abstract class for unclassified Thryonomys (no rank).
/// NCBI TaxId: 2648170
/// </summary>
public abstract class unclassified_Thryonomys : Thryonomys, Iunclassified_Thryonomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Thryonomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2648170;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Thryonomys";
}
