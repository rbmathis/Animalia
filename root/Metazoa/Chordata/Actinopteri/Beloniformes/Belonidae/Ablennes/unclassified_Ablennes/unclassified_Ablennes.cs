using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beloniformes.Belonidae.Ablennes;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beloniformes.Belonidae.Ablennes.unclassified_Ablennes;

/// <summary>
/// Abstract class for unclassified Ablennes (no rank).
/// NCBI TaxId: 2676920
/// </summary>
public abstract class unclassified_Ablennes : Ablennes, Iunclassified_Ablennes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Ablennes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2676920;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Ablennes";
}
