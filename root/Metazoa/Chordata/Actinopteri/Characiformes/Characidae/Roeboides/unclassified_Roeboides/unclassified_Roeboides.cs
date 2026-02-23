using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characidae.Roeboides;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characidae.Roeboides.unclassified_Roeboides;

/// <summary>
/// Abstract class for unclassified Roeboides (no rank).
/// NCBI TaxId: 2623846
/// </summary>
public abstract class unclassified_Roeboides : Roeboides, Iunclassified_Roeboides
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Roeboides";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2623846;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Roeboides";
}
