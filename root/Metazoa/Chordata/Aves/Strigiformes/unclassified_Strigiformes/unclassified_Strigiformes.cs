using AnimalKingdom.root.Metazoa.Chordata.Aves.Strigiformes;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Strigiformes.unclassified_Strigiformes;

/// <summary>
/// Abstract class for unclassified Strigiformes (no rank).
/// NCBI TaxId: 772159
/// </summary>
public abstract class unclassified_Strigiformes : Strigiformes, Iunclassified_Strigiformes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Strigiformes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 772159;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Strigiformes";
}
