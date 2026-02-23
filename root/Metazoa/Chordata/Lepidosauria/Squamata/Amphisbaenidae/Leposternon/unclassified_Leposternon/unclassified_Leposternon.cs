using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Amphisbaenidae.Leposternon;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Amphisbaenidae.Leposternon.unclassified_Leposternon;

/// <summary>
/// Abstract class for unclassified Leposternon (no rank).
/// NCBI TaxId: 2646252
/// </summary>
public abstract class unclassified_Leposternon : Leposternon, Iunclassified_Leposternon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Leposternon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2646252;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Leposternon";
}
