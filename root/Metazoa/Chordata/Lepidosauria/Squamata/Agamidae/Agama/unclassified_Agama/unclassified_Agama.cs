using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae.Agama;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae.Agama.unclassified_Agama;

/// <summary>
/// Abstract class for unclassified Agama (no rank).
/// NCBI TaxId: 2626330
/// </summary>
public abstract class unclassified_Agama : Agama, Iunclassified_Agama
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Agama";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2626330;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Agama";
}
