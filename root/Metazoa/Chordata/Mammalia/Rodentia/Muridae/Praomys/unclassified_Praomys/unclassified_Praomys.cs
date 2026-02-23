using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Praomys;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Praomys.unclassified_Praomys;

/// <summary>
/// Abstract class for unclassified Praomys (no rank).
/// NCBI TaxId: 2619336
/// </summary>
public abstract class unclassified_Praomys : Praomys, Iunclassified_Praomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Praomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2619336;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Praomys";
}
