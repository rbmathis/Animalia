using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Tylomys;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Tylomys.unclassified_Tylomys;

/// <summary>
/// Abstract class for unclassified Tylomys (no rank).
/// NCBI TaxId: 2621197
/// </summary>
public abstract class unclassified_Tylomys : Tylomys, Iunclassified_Tylomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Tylomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2621197;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Tylomys";
}
