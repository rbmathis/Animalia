using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ranidae.Abavorana;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ranidae.Abavorana.unclassified_Abavorana;

/// <summary>
/// Abstract class for unclassified Abavorana (no rank).
/// NCBI TaxId: 2630332
/// </summary>
public abstract class unclassified_Abavorana : Abavorana, Iunclassified_Abavorana
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Abavorana";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2630332;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Abavorana";
}
