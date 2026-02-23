using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lamprophiidae.Duberria;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lamprophiidae.Duberria.unclassified_Duberria;

/// <summary>
/// Abstract class for unclassified Duberria (no rank).
/// NCBI TaxId: 2620546
/// </summary>
public abstract class unclassified_Duberria : Duberria, Iunclassified_Duberria
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Duberria";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2620546;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Duberria";
}
