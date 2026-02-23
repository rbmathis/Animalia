using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Didelphimorphia.Didelphidae.Metachirus;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Didelphimorphia.Didelphidae.Metachirus.unclassified_Metachirus;

/// <summary>
/// Abstract class for unclassified Metachirus (no rank).
/// NCBI TaxId: 3019943
/// </summary>
public abstract class unclassified_Metachirus : Metachirus, Iunclassified_Metachirus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Metachirus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3019943;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Metachirus";
}
