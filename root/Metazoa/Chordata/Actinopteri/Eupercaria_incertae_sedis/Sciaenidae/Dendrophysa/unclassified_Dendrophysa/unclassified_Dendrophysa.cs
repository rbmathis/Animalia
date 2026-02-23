using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae.Dendrophysa;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae.Dendrophysa.unclassified_Dendrophysa;

/// <summary>
/// Abstract class for unclassified Dendrophysa (no rank).
/// NCBI TaxId: 2640200
/// </summary>
public abstract class unclassified_Dendrophysa : Dendrophysa, Iunclassified_Dendrophysa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Dendrophysa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2640200;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Dendrophysa";
}
