using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Didelphimorphia;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Didelphimorphia.unclassified_Didelphimorphia;

/// <summary>
/// Abstract class for unclassified Didelphimorphia (no rank).
/// NCBI TaxId: 727678
/// </summary>
public abstract class unclassified_Didelphimorphia : Didelphimorphia, Iunclassified_Didelphimorphia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Didelphimorphia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 727678;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Didelphimorphia";
}
