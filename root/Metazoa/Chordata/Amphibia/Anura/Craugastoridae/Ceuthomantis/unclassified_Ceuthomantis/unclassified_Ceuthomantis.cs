using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Craugastoridae.Ceuthomantis;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Craugastoridae.Ceuthomantis.unclassified_Ceuthomantis;

/// <summary>
/// Abstract class for unclassified Ceuthomantis (no rank).
/// NCBI TaxId: 2698112
/// </summary>
public abstract class unclassified_Ceuthomantis : Ceuthomantis, Iunclassified_Ceuthomantis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Ceuthomantis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2698112;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Ceuthomantis";
}
