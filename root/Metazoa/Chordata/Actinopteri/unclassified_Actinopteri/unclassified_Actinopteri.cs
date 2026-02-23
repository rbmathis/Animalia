using AnimalKingdom.root.Metazoa.Chordata.Actinopteri;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.unclassified_Actinopteri;

/// <summary>
/// Abstract class for unclassified Actinopteri (no rank).
/// NCBI TaxId: 3063545
/// </summary>
public abstract class unclassified_Actinopteri : Actinopteri, Iunclassified_Actinopteri
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Actinopteri";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3063545;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Actinopteri";
}
