using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Spalerosophis;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Spalerosophis.unclassified_Spalerosophis;

/// <summary>
/// Abstract class for unclassified Spalerosophis (no rank).
/// NCBI TaxId: 2929071
/// </summary>
public abstract class unclassified_Spalerosophis : Spalerosophis, Iunclassified_Spalerosophis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Spalerosophis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2929071;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Spalerosophis";
}
