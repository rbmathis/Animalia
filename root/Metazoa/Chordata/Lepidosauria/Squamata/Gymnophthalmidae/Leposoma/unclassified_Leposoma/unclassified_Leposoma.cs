using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae.Leposoma;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae.Leposoma.unclassified_Leposoma;

/// <summary>
/// Abstract class for unclassified Leposoma (no rank).
/// NCBI TaxId: 2646988
/// </summary>
public abstract class unclassified_Leposoma : Leposoma, Iunclassified_Leposoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Leposoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2646988;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Leposoma";
}
