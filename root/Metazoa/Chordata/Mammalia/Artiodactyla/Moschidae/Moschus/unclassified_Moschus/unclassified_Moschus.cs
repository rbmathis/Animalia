using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Moschidae.Moschus;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Moschidae.Moschus.unclassified_Moschus;

/// <summary>
/// Abstract class for unclassified Moschus (no rank).
/// NCBI TaxId: 2645182
/// </summary>
public abstract class unclassified_Moschus : Moschus, Iunclassified_Moschus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Moschus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2645182;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Moschus";
}
