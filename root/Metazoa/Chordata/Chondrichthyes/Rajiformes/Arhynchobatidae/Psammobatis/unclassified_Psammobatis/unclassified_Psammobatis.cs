using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Rajiformes.Arhynchobatidae.Psammobatis;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Rajiformes.Arhynchobatidae.Psammobatis.unclassified_Psammobatis;

/// <summary>
/// Abstract class for unclassified Psammobatis (no rank).
/// NCBI TaxId: 2624295
/// </summary>
public abstract class unclassified_Psammobatis : Psammobatis, Iunclassified_Psammobatis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Psammobatis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2624295;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Psammobatis";
}
