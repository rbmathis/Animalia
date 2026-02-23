using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lamprophiidae.Gonionotophis;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lamprophiidae.Gonionotophis.unclassified_Gonionotophis;

/// <summary>
/// Abstract class for unclassified Gonionotophis (no rank).
/// NCBI TaxId: 2638531
/// </summary>
public abstract class unclassified_Gonionotophis : Gonionotophis, Iunclassified_Gonionotophis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Gonionotophis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2638531;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Gonionotophis";
}
