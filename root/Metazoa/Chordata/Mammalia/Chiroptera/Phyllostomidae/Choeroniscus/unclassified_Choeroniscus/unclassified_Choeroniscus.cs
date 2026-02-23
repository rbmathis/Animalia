using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Phyllostomidae.Choeroniscus;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Phyllostomidae.Choeroniscus.unclassified_Choeroniscus;

/// <summary>
/// Abstract class for unclassified Choeroniscus (no rank).
/// NCBI TaxId: 2627912
/// </summary>
public abstract class unclassified_Choeroniscus : Choeroniscus, Iunclassified_Choeroniscus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Choeroniscus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2627912;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Choeroniscus";
}
