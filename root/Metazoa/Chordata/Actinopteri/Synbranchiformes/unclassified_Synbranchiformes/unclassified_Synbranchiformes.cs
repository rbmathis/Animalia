using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Synbranchiformes;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Synbranchiformes.unclassified_Synbranchiformes;

/// <summary>
/// Abstract class for unclassified Synbranchiformes (no rank).
/// NCBI TaxId: 732572
/// </summary>
public abstract class unclassified_Synbranchiformes : Synbranchiformes, Iunclassified_Synbranchiformes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Synbranchiformes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 732572;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Synbranchiformes";
}
