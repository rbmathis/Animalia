using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.unclassified_Murinae;

/// <summary>
/// Abstract class for unclassified Murinae (no rank).
/// NCBI TaxId: 1217599
/// </summary>
public abstract class unclassified_Murinae : Muridae, Iunclassified_Murinae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Murinae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1217599;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Murinae";
}
