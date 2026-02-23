using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Pteropodidae.Megaerops;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Pteropodidae.Megaerops.unclassified_Megaerops;

/// <summary>
/// Abstract class for unclassified Megaerops (no rank).
/// NCBI TaxId: 2944748
/// </summary>
public abstract class unclassified_Megaerops : Megaerops, Iunclassified_Megaerops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Megaerops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2944748;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Megaerops";
}
