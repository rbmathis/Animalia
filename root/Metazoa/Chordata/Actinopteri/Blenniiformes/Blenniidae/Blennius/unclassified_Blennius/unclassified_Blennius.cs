using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Blenniidae.Blennius;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Blenniidae.Blennius.unclassified_Blennius;

/// <summary>
/// Abstract class for unclassified Blennius (no rank).
/// NCBI TaxId: 2619807
/// </summary>
public abstract class unclassified_Blennius : Blennius, Iunclassified_Blennius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Blennius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2619807;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Blennius";
}
