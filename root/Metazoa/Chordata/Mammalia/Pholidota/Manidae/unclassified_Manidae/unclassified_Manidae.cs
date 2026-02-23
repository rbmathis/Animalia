using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Pholidota.Manidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Pholidota.Manidae.unclassified_Manidae;

/// <summary>
/// Abstract class for unclassified Manidae (no rank).
/// NCBI TaxId: 3043965
/// </summary>
public abstract class unclassified_Manidae : Manidae, Iunclassified_Manidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Manidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3043965;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Manidae";
}
