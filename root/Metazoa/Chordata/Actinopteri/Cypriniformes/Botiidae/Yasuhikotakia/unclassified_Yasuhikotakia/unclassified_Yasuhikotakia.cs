using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Botiidae.Yasuhikotakia;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Botiidae.Yasuhikotakia.unclassified_Yasuhikotakia;

/// <summary>
/// Abstract class for unclassified Yasuhikotakia (no rank).
/// NCBI TaxId: 2632233
/// </summary>
public abstract class unclassified_Yasuhikotakia : Yasuhikotakia, Iunclassified_Yasuhikotakia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Yasuhikotakia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2632233;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Yasuhikotakia";
}
