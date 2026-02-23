using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ranidae.Humerana;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ranidae.Humerana.unclassified_Humerana;

/// <summary>
/// Abstract class for unclassified Humerana (no rank).
/// NCBI TaxId: 2640355
/// </summary>
public abstract class unclassified_Humerana : Humerana, Iunclassified_Humerana
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Humerana";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2640355;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Humerana";
}
