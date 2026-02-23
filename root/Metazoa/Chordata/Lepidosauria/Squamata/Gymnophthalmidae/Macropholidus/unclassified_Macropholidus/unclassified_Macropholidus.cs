using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae.Macropholidus;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae.Macropholidus.unclassified_Macropholidus;

/// <summary>
/// Abstract class for unclassified Macropholidus (no rank).
/// NCBI TaxId: 2625977
/// </summary>
public abstract class unclassified_Macropholidus : Macropholidus, Iunclassified_Macropholidus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Macropholidus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2625977;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Macropholidus";
}
