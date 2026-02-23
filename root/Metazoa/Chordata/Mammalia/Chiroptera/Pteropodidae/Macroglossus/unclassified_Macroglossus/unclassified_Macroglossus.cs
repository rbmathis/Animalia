using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Pteropodidae.Macroglossus;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Pteropodidae.Macroglossus.unclassified_Macroglossus;

/// <summary>
/// Abstract class for unclassified Macroglossus (no rank).
/// NCBI TaxId: 2620160
/// </summary>
public abstract class unclassified_Macroglossus : Macroglossus, Iunclassified_Macroglossus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Macroglossus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2620160;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Macroglossus";
}
