using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Blenniidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Blenniidae.unclassified_Blenniidae;

/// <summary>
/// Abstract class for unclassified Blenniidae (no rank).
/// NCBI TaxId: 1183114
/// </summary>
public abstract class unclassified_Blenniidae : Blenniidae, Iunclassified_Blenniidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Blenniidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1183114;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Blenniidae";
}
