using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Moronidae.Dicentrarchus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Moronidae.Dicentrarchus.unclassified_Dicentrarchus;

/// <summary>
/// Abstract class for unclassified Dicentrarchus (no rank).
/// NCBI TaxId: 2646938
/// </summary>
public abstract class unclassified_Dicentrarchus : Dicentrarchus, Iunclassified_Dicentrarchus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Dicentrarchus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2646938;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Dicentrarchus";
}
