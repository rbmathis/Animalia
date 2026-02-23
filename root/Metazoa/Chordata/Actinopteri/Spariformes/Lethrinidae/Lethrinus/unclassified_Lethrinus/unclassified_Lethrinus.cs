using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Lethrinidae.Lethrinus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Lethrinidae.Lethrinus.unclassified_Lethrinus;

/// <summary>
/// Abstract class for unclassified Lethrinus (no rank).
/// NCBI TaxId: 2618487
/// </summary>
public abstract class unclassified_Lethrinus : Lethrinus, Iunclassified_Lethrinus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Lethrinus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2618487;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Lethrinus";
}
