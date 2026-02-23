using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Salmoniformes.Salmonidae.Salvelinus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Salmoniformes.Salmonidae.Salvelinus.unclassified_Salvelinus;

/// <summary>
/// Abstract class for unclassified Salvelinus (no rank).
/// NCBI TaxId: 2619774
/// </summary>
public abstract class unclassified_Salvelinus : Salvelinus, Iunclassified_Salvelinus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Salvelinus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2619774;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Salvelinus";
}
