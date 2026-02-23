using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Echimyidae.Thrichomys;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Echimyidae.Thrichomys.unclassified_Thrichomys;

/// <summary>
/// Abstract class for unclassified Thrichomys (no rank).
/// NCBI TaxId: 2639369
/// </summary>
public abstract class unclassified_Thrichomys : Thrichomys, Iunclassified_Thrichomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Thrichomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2639369;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Thrichomys";
}
