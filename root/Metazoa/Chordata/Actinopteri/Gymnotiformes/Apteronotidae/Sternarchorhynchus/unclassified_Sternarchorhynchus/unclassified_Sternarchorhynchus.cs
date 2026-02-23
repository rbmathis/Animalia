using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gymnotiformes.Apteronotidae.Sternarchorhynchus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gymnotiformes.Apteronotidae.Sternarchorhynchus.unclassified_Sternarchorhynchus;

/// <summary>
/// Abstract class for unclassified Sternarchorhynchus (no rank).
/// NCBI TaxId: 2633475
/// </summary>
public abstract class unclassified_Sternarchorhynchus : Sternarchorhynchus, Iunclassified_Sternarchorhynchus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Sternarchorhynchus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2633475;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Sternarchorhynchus";
}
