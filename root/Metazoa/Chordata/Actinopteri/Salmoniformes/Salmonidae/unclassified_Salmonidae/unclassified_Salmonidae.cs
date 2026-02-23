using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Salmoniformes.Salmonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Salmoniformes.Salmonidae.unclassified_Salmonidae;

/// <summary>
/// Abstract class for unclassified Salmonidae (no rank).
/// NCBI TaxId: 132194
/// </summary>
public abstract class unclassified_Salmonidae : Salmonidae, Iunclassified_Salmonidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Salmonidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 132194;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Salmonidae";
}
