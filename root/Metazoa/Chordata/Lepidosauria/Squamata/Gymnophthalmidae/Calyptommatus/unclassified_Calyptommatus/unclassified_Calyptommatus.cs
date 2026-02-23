using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae.Calyptommatus;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae.Calyptommatus.unclassified_Calyptommatus;

/// <summary>
/// Abstract class for unclassified Calyptommatus (no rank).
/// NCBI TaxId: 2925373
/// </summary>
public abstract class unclassified_Calyptommatus : Calyptommatus, Iunclassified_Calyptommatus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Calyptommatus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2925373;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Calyptommatus";
}
