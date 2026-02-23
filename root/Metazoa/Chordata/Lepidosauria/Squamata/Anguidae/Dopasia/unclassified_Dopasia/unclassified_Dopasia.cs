using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Anguidae.Dopasia;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Anguidae.Dopasia.unclassified_Dopasia;

/// <summary>
/// Abstract class for unclassified Dopasia (no rank).
/// NCBI TaxId: 2773590
/// </summary>
public abstract class unclassified_Dopasia : Dopasia, Iunclassified_Dopasia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Dopasia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2773590;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Dopasia";
}
