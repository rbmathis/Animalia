using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Boana;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Boana.unclassified_Boana;

/// <summary>
/// Abstract class for unclassified Boana (no rank).
/// NCBI TaxId: 2640266
/// </summary>
public abstract class unclassified_Boana : Boana, Iunclassified_Boana
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Boana";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2640266;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Boana";
}
