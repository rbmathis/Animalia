using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Mesocricetus;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Mesocricetus.unclassified_Mesocricetus;

/// <summary>
/// Abstract class for unclassified Mesocricetus (no rank).
/// NCBI TaxId: 2634077
/// </summary>
public abstract class unclassified_Mesocricetus : Mesocricetus, Iunclassified_Mesocricetus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Mesocricetus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2634077;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Mesocricetus";
}
