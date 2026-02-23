using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Dipodidae.Sicista;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Dipodidae.Sicista.unclassified_Sicista;

/// <summary>
/// Abstract class for unclassified Sicista (no rank).
/// NCBI TaxId: 3409896
/// </summary>
public abstract class unclassified_Sicista : Sicista, Iunclassified_Sicista
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Sicista";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3409896;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Sicista";
}
