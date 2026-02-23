using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae.unclassified_Gymnophthalmidae;

/// <summary>
/// Abstract class for unclassified Gymnophthalmidae (no rank).
/// NCBI TaxId: 1819680
/// </summary>
public abstract class unclassified_Gymnophthalmidae : Gymnophthalmidae, Iunclassified_Gymnophthalmidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Gymnophthalmidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1819680;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Gymnophthalmidae";
}
