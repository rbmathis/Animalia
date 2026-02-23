using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Blenniidae.Istiblennius;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Blenniidae.Istiblennius.unclassified_Istiblennius;

/// <summary>
/// Abstract class for unclassified Istiblennius (no rank).
/// NCBI TaxId: 2949119
/// </summary>
public abstract class unclassified_Istiblennius : Istiblennius, Iunclassified_Istiblennius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Istiblennius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2949119;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Istiblennius";
}
