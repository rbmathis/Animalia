using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Salmoniformes;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Salmoniformes.unclassified_Salmoniformes;

/// <summary>
/// Abstract class for unclassified Salmoniformes (no rank).
/// NCBI TaxId: 794806
/// </summary>
public abstract class unclassified_Salmoniformes : Salmoniformes, Iunclassified_Salmoniformes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Salmoniformes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 794806;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Salmoniformes";
}
