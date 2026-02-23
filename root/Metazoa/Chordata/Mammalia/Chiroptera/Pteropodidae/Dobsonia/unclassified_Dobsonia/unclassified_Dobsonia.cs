using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Pteropodidae.Dobsonia;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Pteropodidae.Dobsonia.unclassified_Dobsonia;

/// <summary>
/// Abstract class for unclassified Dobsonia (no rank).
/// NCBI TaxId: 2719124
/// </summary>
public abstract class unclassified_Dobsonia : Dobsonia, Iunclassified_Dobsonia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Dobsonia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2719124;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Dobsonia";
}
