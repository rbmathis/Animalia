using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Kurtiformes.Apogonidae.Phaeoptyx;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Kurtiformes.Apogonidae.Phaeoptyx.unclassified_Phaeoptyx;

/// <summary>
/// Abstract class for unclassified Phaeoptyx (no rank).
/// NCBI TaxId: 2632818
/// </summary>
public abstract class unclassified_Phaeoptyx : Phaeoptyx, Iunclassified_Phaeoptyx
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Phaeoptyx";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2632818;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Phaeoptyx";
}
