using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Hyracoidea.Procaviidae.Dendrohyrax;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Hyracoidea.Procaviidae.Dendrohyrax.unclassified_Dendrohyrax;

/// <summary>
/// Abstract class for unclassified Dendrohyrax (no rank).
/// NCBI TaxId: 3413536
/// </summary>
public abstract class unclassified_Dendrohyrax : Dendrohyrax, Iunclassified_Dendrohyrax
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Dendrohyrax";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3413536;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Dendrohyrax";
}
