using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.unclassified_Labridae;

/// <summary>
/// Abstract class for unclassified Labridae (no rank).
/// NCBI TaxId: 1182087
/// </summary>
public abstract class unclassified_Labridae : Labridae, Iunclassified_Labridae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Labridae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1182087;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Labridae";
}
