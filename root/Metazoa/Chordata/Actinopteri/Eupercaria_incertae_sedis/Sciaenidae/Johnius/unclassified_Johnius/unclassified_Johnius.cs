using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae.Johnius;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae.Johnius.unclassified_Johnius;

/// <summary>
/// Abstract class for unclassified Johnius (no rank).
/// NCBI TaxId: 2625581
/// </summary>
public abstract class unclassified_Johnius : Johnius, Iunclassified_Johnius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Johnius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2625581;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Johnius";
}
