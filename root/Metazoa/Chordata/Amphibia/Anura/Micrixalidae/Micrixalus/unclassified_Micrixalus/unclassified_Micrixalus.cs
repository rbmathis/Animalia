using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Micrixalidae.Micrixalus;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Micrixalidae.Micrixalus.unclassified_Micrixalus;

/// <summary>
/// Abstract class for unclassified Micrixalus (no rank).
/// NCBI TaxId: 2622368
/// </summary>
public abstract class unclassified_Micrixalus : Micrixalus, Iunclassified_Micrixalus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Micrixalus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2622368;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Micrixalus";
}
