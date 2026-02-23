using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Janetaescincus;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Janetaescincus.unclassified_Janetaescincus;

/// <summary>
/// Abstract class for unclassified Janetaescincus (no rank).
/// NCBI TaxId: 2644184
/// </summary>
public abstract class unclassified_Janetaescincus : Janetaescincus, Iunclassified_Janetaescincus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Janetaescincus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2644184;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Janetaescincus";
}
