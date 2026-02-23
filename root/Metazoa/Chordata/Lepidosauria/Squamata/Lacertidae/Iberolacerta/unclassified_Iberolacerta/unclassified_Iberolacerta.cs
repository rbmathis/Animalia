using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lacertidae.Iberolacerta;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lacertidae.Iberolacerta.unclassified_Iberolacerta;

/// <summary>
/// Abstract class for unclassified Iberolacerta (no rank).
/// NCBI TaxId: 2647097
/// </summary>
public abstract class unclassified_Iberolacerta : Iberolacerta, Iunclassified_Iberolacerta
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Iberolacerta";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2647097;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Iberolacerta";
}
