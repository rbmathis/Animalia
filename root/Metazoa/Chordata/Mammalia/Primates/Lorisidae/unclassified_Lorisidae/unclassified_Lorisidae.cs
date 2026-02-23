using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Lorisidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Lorisidae.unclassified_Lorisidae;

/// <summary>
/// Abstract class for unclassified Lorisidae (no rank).
/// NCBI TaxId: 3413538
/// </summary>
public abstract class unclassified_Lorisidae : Lorisidae, Iunclassified_Lorisidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Lorisidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3413538;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Lorisidae";
}
