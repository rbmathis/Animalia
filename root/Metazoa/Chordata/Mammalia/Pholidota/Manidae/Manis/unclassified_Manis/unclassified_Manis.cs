using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Pholidota.Manidae.Manis;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Pholidota.Manidae.Manis.unclassified_Manis;

/// <summary>
/// Abstract class for unclassified Manis (no rank).
/// NCBI TaxId: 2643178
/// </summary>
public abstract class unclassified_Manis : Manis, Iunclassified_Manis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Manis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2643178;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Manis";
}
