using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Alsodidae.Alsodes;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Alsodidae.Alsodes.unclassified_Alsodes;

/// <summary>
/// Abstract class for unclassified Alsodes (no rank).
/// NCBI TaxId: 2637183
/// </summary>
public abstract class unclassified_Alsodes : Alsodes, Iunclassified_Alsodes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Alsodes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2637183;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Alsodes";
}
