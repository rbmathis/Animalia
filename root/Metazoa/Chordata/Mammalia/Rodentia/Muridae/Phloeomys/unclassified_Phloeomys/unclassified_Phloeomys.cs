using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Phloeomys;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Phloeomys.unclassified_Phloeomys;

/// <summary>
/// Abstract class for unclassified Phloeomys (no rank).
/// NCBI TaxId: 2630845
/// </summary>
public abstract class unclassified_Phloeomys : Phloeomys, Iunclassified_Phloeomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Phloeomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2630845;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Phloeomys";
}
