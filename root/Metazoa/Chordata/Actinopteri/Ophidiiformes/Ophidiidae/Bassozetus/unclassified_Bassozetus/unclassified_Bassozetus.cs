using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Ophidiidae.Bassozetus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Ophidiidae.Bassozetus.unclassified_Bassozetus;

/// <summary>
/// Abstract class for unclassified Bassozetus (no rank).
/// NCBI TaxId: 2726546
/// </summary>
public abstract class unclassified_Bassozetus : Bassozetus, Iunclassified_Bassozetus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Bassozetus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2726546;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Bassozetus";
}
