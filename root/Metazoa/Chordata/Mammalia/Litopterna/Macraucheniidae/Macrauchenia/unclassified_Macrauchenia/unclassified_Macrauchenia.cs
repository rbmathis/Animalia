using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Litopterna.Macraucheniidae.Macrauchenia;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Litopterna.Macraucheniidae.Macrauchenia.unclassified_Macrauchenia;

/// <summary>
/// Abstract class for unclassified Macrauchenia (no rank).
/// NCBI TaxId: 2618932
/// </summary>
public abstract class unclassified_Macrauchenia : Macrauchenia, Iunclassified_Macrauchenia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Macrauchenia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2618932;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Macrauchenia";
}
