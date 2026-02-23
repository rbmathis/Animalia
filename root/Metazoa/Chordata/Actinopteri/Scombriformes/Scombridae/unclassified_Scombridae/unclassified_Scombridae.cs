using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Scombridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Scombridae.unclassified_Scombridae;

/// <summary>
/// Abstract class for unclassified Scombridae (no rank).
/// NCBI TaxId: 186750
/// </summary>
public abstract class unclassified_Scombridae : Scombridae, Iunclassified_Scombridae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Scombridae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 186750;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Scombridae";
}
