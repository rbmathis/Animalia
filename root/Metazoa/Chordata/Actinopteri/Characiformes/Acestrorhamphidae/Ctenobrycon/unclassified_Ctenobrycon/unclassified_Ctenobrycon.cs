using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Acestrorhamphidae.Ctenobrycon;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Acestrorhamphidae.Ctenobrycon.unclassified_Ctenobrycon;

/// <summary>
/// Abstract class for unclassified Ctenobrycon (no rank).
/// NCBI TaxId: 2984181
/// </summary>
public abstract class unclassified_Ctenobrycon : Ctenobrycon, Iunclassified_Ctenobrycon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Ctenobrycon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2984181;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Ctenobrycon";
}
