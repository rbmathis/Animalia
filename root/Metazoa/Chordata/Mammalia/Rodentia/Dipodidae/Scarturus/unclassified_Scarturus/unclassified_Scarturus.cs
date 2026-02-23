using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Dipodidae.Scarturus;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Dipodidae.Scarturus.unclassified_Scarturus;

/// <summary>
/// Abstract class for unclassified Scarturus (no rank).
/// NCBI TaxId: 2897420
/// </summary>
public abstract class unclassified_Scarturus : Scarturus, Iunclassified_Scarturus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Scarturus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2897420;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Scarturus";
}
