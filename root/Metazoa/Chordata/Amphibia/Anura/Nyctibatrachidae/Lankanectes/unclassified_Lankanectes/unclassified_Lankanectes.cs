using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Nyctibatrachidae.Lankanectes;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Nyctibatrachidae.Lankanectes.unclassified_Lankanectes;

/// <summary>
/// Abstract class for unclassified Lankanectes (no rank).
/// NCBI TaxId: 2623132
/// </summary>
public abstract class unclassified_Lankanectes : Lankanectes, Iunclassified_Lankanectes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Lankanectes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2623132;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Lankanectes";
}
