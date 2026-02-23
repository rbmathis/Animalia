using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae.Imantodes;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae.Imantodes.unclassified_Imantodes;

/// <summary>
/// Abstract class for unclassified Imantodes (no rank).
/// NCBI TaxId: 3157892
/// </summary>
public abstract class unclassified_Imantodes : Imantodes, Iunclassified_Imantodes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Imantodes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3157892;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Imantodes";
}
