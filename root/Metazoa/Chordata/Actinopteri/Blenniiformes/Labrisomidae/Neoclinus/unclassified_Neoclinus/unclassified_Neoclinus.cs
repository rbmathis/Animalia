using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Labrisomidae.Neoclinus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Labrisomidae.Neoclinus.unclassified_Neoclinus;

/// <summary>
/// Abstract class for unclassified Neoclinus (no rank).
/// NCBI TaxId: 3445703
/// </summary>
public abstract class unclassified_Neoclinus : Neoclinus, Iunclassified_Neoclinus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Neoclinus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3445703;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Neoclinus";
}
