using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Uropeltidae.Uropeltis;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Uropeltidae.Uropeltis.unclassified_Uropeltis;

/// <summary>
/// Abstract class for unclassified Uropeltis (no rank).
/// NCBI TaxId: 313446
/// </summary>
public abstract class unclassified_Uropeltis : Uropeltis, Iunclassified_Uropeltis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Uropeltis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 313446;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Uropeltis";
}
