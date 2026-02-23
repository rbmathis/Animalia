using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Didelphimorphia.Didelphidae.Marmosa;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Didelphimorphia.Didelphidae.Marmosa.unclassified_Micoureus;

/// <summary>
/// Abstract class for unclassified Micoureus (no rank).
/// NCBI TaxId: 2747337
/// </summary>
public abstract class unclassified_Micoureus : Marmosa, Iunclassified_Micoureus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Micoureus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2747337;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Micoureus";
}
