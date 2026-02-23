using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.unclassified_Stomiiformes;

/// <summary>
/// Abstract class for unclassified Stomiiformes (no rank).
/// NCBI TaxId: 727673
/// </summary>
public abstract class unclassified_Stomiiformes : Stomiiformes, Iunclassified_Stomiiformes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Stomiiformes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 727673;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Stomiiformes";
}
