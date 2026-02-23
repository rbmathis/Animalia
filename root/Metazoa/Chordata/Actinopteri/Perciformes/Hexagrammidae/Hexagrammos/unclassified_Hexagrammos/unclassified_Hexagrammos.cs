using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Hexagrammidae.Hexagrammos;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Hexagrammidae.Hexagrammos.unclassified_Hexagrammos;

/// <summary>
/// Abstract class for unclassified Hexagrammos (no rank).
/// NCBI TaxId: 2646105
/// </summary>
public abstract class unclassified_Hexagrammos : Hexagrammos, Iunclassified_Hexagrammos
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Hexagrammos";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2646105;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Hexagrammos";
}
