using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Carcharhinidae.Rhizoprionodon;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Carcharhinidae.Rhizoprionodon.unclassified_Rhizoprionodon;

/// <summary>
/// Abstract class for unclassified Rhizoprionodon (no rank).
/// NCBI TaxId: 2628129
/// </summary>
public abstract class unclassified_Rhizoprionodon : Rhizoprionodon, Iunclassified_Rhizoprionodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Rhizoprionodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2628129;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Rhizoprionodon";
}
