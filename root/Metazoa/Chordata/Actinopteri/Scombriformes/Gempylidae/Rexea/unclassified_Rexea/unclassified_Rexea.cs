using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Gempylidae.Rexea;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Gempylidae.Rexea.unclassified_Rexea;

/// <summary>
/// Abstract class for unclassified Rexea (no rank).
/// NCBI TaxId: 2636702
/// </summary>
public abstract class unclassified_Rexea : Rexea, Iunclassified_Rexea
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Rexea";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2636702;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Rexea";
}
