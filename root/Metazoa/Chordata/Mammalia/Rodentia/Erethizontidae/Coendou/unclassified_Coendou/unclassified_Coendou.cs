using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Erethizontidae.Coendou;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Erethizontidae.Coendou.unclassified_Coendou;

/// <summary>
/// Abstract class for unclassified Coendou (no rank).
/// NCBI TaxId: 2630139
/// </summary>
public abstract class unclassified_Coendou : Coendou, Iunclassified_Coendou
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Coendou";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2630139;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Coendou";
}
