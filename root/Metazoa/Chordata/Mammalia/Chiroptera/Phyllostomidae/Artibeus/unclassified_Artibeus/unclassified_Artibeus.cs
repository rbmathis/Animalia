using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Phyllostomidae.Artibeus;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Phyllostomidae.Artibeus.unclassified_Artibeus;

/// <summary>
/// Abstract class for unclassified Artibeus (no rank).
/// NCBI TaxId: 2625567
/// </summary>
public abstract class unclassified_Artibeus : Artibeus, Iunclassified_Artibeus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Artibeus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2625567;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Artibeus";
}
