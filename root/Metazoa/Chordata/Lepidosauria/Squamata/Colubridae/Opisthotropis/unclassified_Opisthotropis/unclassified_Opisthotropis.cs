using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Opisthotropis;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Opisthotropis.unclassified_Opisthotropis;

/// <summary>
/// Abstract class for unclassified Opisthotropis (no rank).
/// NCBI TaxId: 2630290
/// </summary>
public abstract class unclassified_Opisthotropis : Opisthotropis, Iunclassified_Opisthotropis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Opisthotropis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2630290;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Opisthotropis";
}
