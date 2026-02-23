using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Corvidae.Artamus;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Corvidae.Artamus.unclassified_Artamus;

/// <summary>
/// Abstract class for unclassified Artamus (no rank).
/// NCBI TaxId: 2624608
/// </summary>
public abstract class unclassified_Artamus : Artamus, Iunclassified_Artamus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Artamus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2624608;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Artamus";
}
