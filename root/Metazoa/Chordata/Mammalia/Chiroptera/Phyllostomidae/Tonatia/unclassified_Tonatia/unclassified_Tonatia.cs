using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Phyllostomidae.Tonatia;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Phyllostomidae.Tonatia.unclassified_Tonatia;

/// <summary>
/// Abstract class for unclassified Tonatia (no rank).
/// NCBI TaxId: 2633921
/// </summary>
public abstract class unclassified_Tonatia : Tonatia, Iunclassified_Tonatia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Tonatia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2633921;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Tonatia";
}
