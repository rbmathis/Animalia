using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Uranoscopiformes.Ammodytidae.Ammodytes;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Uranoscopiformes.Ammodytidae.Ammodytes.unclassified_Ammodytes;

/// <summary>
/// Abstract class for unclassified Ammodytes (no rank).
/// NCBI TaxId: 2644905
/// </summary>
public abstract class unclassified_Ammodytes : Ammodytes, Iunclassified_Ammodytes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Ammodytes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2644905;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Ammodytes";
}
