using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Anthiadidae.Tosanoides;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Anthiadidae.Tosanoides.unclassified_Tosanoides;

/// <summary>
/// Abstract class for unclassified Tosanoides (no rank).
/// NCBI TaxId: 3414479
/// </summary>
public abstract class unclassified_Tosanoides : Tosanoides, Iunclassified_Tosanoides
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Tosanoides";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3414479;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Tosanoides";
}
