using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Lerista;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Lerista.unclassified_Lerista;

/// <summary>
/// Abstract class for unclassified Lerista (no rank).
/// NCBI TaxId: 2646479
/// </summary>
public abstract class unclassified_Lerista : Lerista, Iunclassified_Lerista
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Lerista";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2646479;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Lerista";
}
