using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Alsodidae.Eupsophus;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Alsodidae.Eupsophus.unclassified_Eupsophus;

/// <summary>
/// Abstract class for unclassified Eupsophus (no rank).
/// NCBI TaxId: 2642388
/// </summary>
public abstract class unclassified_Eupsophus : Eupsophus, Iunclassified_Eupsophus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Eupsophus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2642388;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Eupsophus";
}
