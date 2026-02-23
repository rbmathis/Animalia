using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Citharinidae.Phago;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Citharinidae.Phago.unclassified_Phago;

/// <summary>
/// Abstract class for unclassified Phago (no rank).
/// NCBI TaxId: 2637592
/// </summary>
public abstract class unclassified_Phago : Phago, Iunclassified_Phago
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Phago";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2637592;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Phago";
}
