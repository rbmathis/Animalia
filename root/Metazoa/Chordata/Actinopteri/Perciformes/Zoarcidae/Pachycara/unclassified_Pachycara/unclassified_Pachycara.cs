using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Zoarcidae.Pachycara;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Zoarcidae.Pachycara.unclassified_Pachycara;

/// <summary>
/// Abstract class for unclassified Pachycara (no rank).
/// NCBI TaxId: 2623518
/// </summary>
public abstract class unclassified_Pachycara : Pachycara, Iunclassified_Pachycara
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pachycara";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2623518;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pachycara";
}
