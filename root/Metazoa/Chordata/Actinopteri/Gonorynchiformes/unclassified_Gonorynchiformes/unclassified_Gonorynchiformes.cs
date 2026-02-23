using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gonorynchiformes;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gonorynchiformes.unclassified_Gonorynchiformes;

/// <summary>
/// Abstract class for unclassified Gonorynchiformes (no rank).
/// NCBI TaxId: 725929
/// </summary>
public abstract class unclassified_Gonorynchiformes : Gonorynchiformes, Iunclassified_Gonorynchiformes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Gonorynchiformes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 725929;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Gonorynchiformes";
}
