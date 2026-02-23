using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Dendrelaphis;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Dendrelaphis.unclassified_Dendrelaphis;

/// <summary>
/// Abstract class for unclassified Dendrelaphis (no rank).
/// NCBI TaxId: 2083035
/// </summary>
public abstract class unclassified_Dendrelaphis : Dendrelaphis, Iunclassified_Dendrelaphis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Dendrelaphis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2083035;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Dendrelaphis";
}
