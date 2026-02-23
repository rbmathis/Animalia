using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Echimyidae.Makalata;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Echimyidae.Makalata.unclassified_Makalata;

/// <summary>
/// Abstract class for unclassified Makalata (no rank).
/// NCBI TaxId: 2624048
/// </summary>
public abstract class unclassified_Makalata : Makalata, Iunclassified_Makalata
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Makalata";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2624048;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Makalata";
}
