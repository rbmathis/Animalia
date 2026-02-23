using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Craugastoridae.Microkayla;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Craugastoridae.Microkayla.unclassified_Microkayla;

/// <summary>
/// Abstract class for unclassified Microkayla (no rank).
/// NCBI TaxId: 2643541
/// </summary>
public abstract class unclassified_Microkayla : Microkayla, Iunclassified_Microkayla
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Microkayla";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2643541;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Microkayla";
}
