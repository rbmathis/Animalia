using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gonorynchiformes.Kneriidae.Kneria;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gonorynchiformes.Kneriidae.Kneria.unclassified_Kneria;

/// <summary>
/// Abstract class for unclassified Kneria (no rank).
/// NCBI TaxId: 2646269
/// </summary>
public abstract class unclassified_Kneria : Kneria, Iunclassified_Kneria
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Kneria";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2646269;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Kneria";
}
