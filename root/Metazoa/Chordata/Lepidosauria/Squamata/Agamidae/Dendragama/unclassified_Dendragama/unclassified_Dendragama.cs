using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae.Dendragama;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae.Dendragama.unclassified_Dendragama;

/// <summary>
/// Abstract class for unclassified Dendragama (no rank).
/// NCBI TaxId: 3467900
/// </summary>
public abstract class unclassified_Dendragama : Dendragama, Iunclassified_Dendragama
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Dendragama";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3467900;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Dendragama";
}
