using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Hemigaleidae.Paragaleus;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Hemigaleidae.Paragaleus.unclassified_Paragaleus;

/// <summary>
/// Abstract class for unclassified Paragaleus (no rank).
/// NCBI TaxId: 2625814
/// </summary>
public abstract class unclassified_Paragaleus : Paragaleus, Iunclassified_Paragaleus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Paragaleus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2625814;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Paragaleus";
}
