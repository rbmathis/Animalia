using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Citharinidae.Ichthyborus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Citharinidae.Ichthyborus.unclassified_Ichthyborus;

/// <summary>
/// Abstract class for unclassified Ichthyborus (no rank).
/// NCBI TaxId: 2635124
/// </summary>
public abstract class unclassified_Ichthyborus : Ichthyborus, Iunclassified_Ichthyborus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Ichthyborus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2635124;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Ichthyborus";
}
