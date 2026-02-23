using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Uranoscopiformes.Ammodytidae.Gymnammodytes;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Uranoscopiformes.Ammodytidae.Gymnammodytes.unclassified_Gymnammodytes;

/// <summary>
/// Abstract class for unclassified Gymnammodytes (no rank).
/// NCBI TaxId: 2747765
/// </summary>
public abstract class unclassified_Gymnammodytes : Gymnammodytes, Iunclassified_Gymnammodytes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Gymnammodytes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2747765;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Gymnammodytes";
}
