using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Heteromyidae.Heteromys;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Heteromyidae.Heteromys.unclassified_Heteromys;

/// <summary>
/// Abstract class for unclassified Heteromys (no rank).
/// NCBI TaxId: 2685047
/// </summary>
public abstract class unclassified_Heteromys : Heteromys, Iunclassified_Heteromys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Heteromys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2685047;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Heteromys";
}
