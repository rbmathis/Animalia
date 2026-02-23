using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Serrasalmidae.Mylesinus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Serrasalmidae.Mylesinus.unclassified_Mylesinus;

/// <summary>
/// Abstract class for unclassified Mylesinus (no rank).
/// NCBI TaxId: 2626089
/// </summary>
public abstract class unclassified_Mylesinus : Mylesinus, Iunclassified_Mylesinus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Mylesinus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2626089;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Mylesinus";
}
