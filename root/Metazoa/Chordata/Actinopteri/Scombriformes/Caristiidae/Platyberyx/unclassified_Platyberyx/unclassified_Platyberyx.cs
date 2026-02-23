using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Caristiidae.Platyberyx;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Caristiidae.Platyberyx.unclassified_Platyberyx;

/// <summary>
/// Abstract class for unclassified Platyberyx (no rank).
/// NCBI TaxId: 2644622
/// </summary>
public abstract class unclassified_Platyberyx : Platyberyx, Iunclassified_Platyberyx
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Platyberyx";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2644622;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Platyberyx";
}
