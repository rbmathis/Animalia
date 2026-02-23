using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Blenniidae.Chasmodes;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Blenniidae.Chasmodes.unclassified_Chasmodes;

/// <summary>
/// Abstract class for unclassified Chasmodes (no rank).
/// NCBI TaxId: 2647477
/// </summary>
public abstract class unclassified_Chasmodes : Chasmodes, Iunclassified_Chasmodes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Chasmodes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2647477;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Chasmodes";
}
