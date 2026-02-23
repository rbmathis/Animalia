using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Mindomys;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Mindomys.unclassified_Mindomys;

/// <summary>
/// Abstract class for unclassified Mindomys (no rank).
/// NCBI TaxId: 2641672
/// </summary>
public abstract class unclassified_Mindomys : Mindomys, Iunclassified_Mindomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Mindomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2641672;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Mindomys";
}
