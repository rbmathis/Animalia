using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Cricetulus;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Cricetulus.unclassified_Cricetulus;

/// <summary>
/// Abstract class for unclassified Cricetulus (no rank).
/// NCBI TaxId: 2621638
/// </summary>
public abstract class unclassified_Cricetulus : Cricetulus, Iunclassified_Cricetulus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Cricetulus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2621638;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Cricetulus";
}
