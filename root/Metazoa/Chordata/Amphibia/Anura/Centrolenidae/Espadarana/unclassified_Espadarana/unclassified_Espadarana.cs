using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Centrolenidae.Espadarana;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Centrolenidae.Espadarana.unclassified_Espadarana;

/// <summary>
/// Abstract class for unclassified Espadarana (no rank).
/// NCBI TaxId: 2624488
/// </summary>
public abstract class unclassified_Espadarana : Espadarana, Iunclassified_Espadarana
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Espadarana";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2624488;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Espadarana";
}
