using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae.Proctoporus;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae.Proctoporus.unclassified_Proctoporus;

/// <summary>
/// Abstract class for unclassified Proctoporus (no rank).
/// NCBI TaxId: 2640130
/// </summary>
public abstract class unclassified_Proctoporus : Proctoporus, Iunclassified_Proctoporus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Proctoporus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2640130;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Proctoporus";
}
