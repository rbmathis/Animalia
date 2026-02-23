using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Bryconidae.Salminus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Bryconidae.Salminus.unclassified_Salminus;

/// <summary>
/// Abstract class for unclassified Salminus (no rank).
/// NCBI TaxId: 2602705
/// </summary>
public abstract class unclassified_Salminus : Salminus, Iunclassified_Salminus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Salminus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2602705;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Salminus";
}
