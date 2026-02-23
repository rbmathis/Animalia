using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lamprophiidae.Ditypophis;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lamprophiidae.Ditypophis.unclassified_Ditypophis;

/// <summary>
/// Abstract class for unclassified Ditypophis (no rank).
/// NCBI TaxId: 2619338
/// </summary>
public abstract class unclassified_Ditypophis : Ditypophis, Iunclassified_Ditypophis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Ditypophis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2619338;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Ditypophis";
}
