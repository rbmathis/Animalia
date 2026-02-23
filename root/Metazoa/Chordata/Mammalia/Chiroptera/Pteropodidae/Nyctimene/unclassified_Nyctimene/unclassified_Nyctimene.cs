using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Pteropodidae.Nyctimene;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Pteropodidae.Nyctimene.unclassified_Nyctimene;

/// <summary>
/// Abstract class for unclassified Nyctimene (no rank).
/// NCBI TaxId: 2721790
/// </summary>
public abstract class unclassified_Nyctimene : Nyctimene, Iunclassified_Nyctimene
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Nyctimene";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2721790;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Nyctimene";
}
