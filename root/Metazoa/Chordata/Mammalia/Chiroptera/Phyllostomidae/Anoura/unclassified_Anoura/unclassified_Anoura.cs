using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Phyllostomidae.Anoura;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Phyllostomidae.Anoura.unclassified_Anoura;

/// <summary>
/// Abstract class for unclassified Anoura (no rank).
/// NCBI TaxId: 2623340
/// </summary>
public abstract class unclassified_Anoura : Anoura, Iunclassified_Anoura
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Anoura";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2623340;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Anoura";
}
