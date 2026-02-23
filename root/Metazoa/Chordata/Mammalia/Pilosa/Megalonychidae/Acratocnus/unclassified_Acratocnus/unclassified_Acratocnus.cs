using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Pilosa.Megalonychidae.Acratocnus;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Pilosa.Megalonychidae.Acratocnus.unclassified_Acratocnus;

/// <summary>
/// Abstract class for unclassified Acratocnus (no rank).
/// NCBI TaxId: 2648349
/// </summary>
public abstract class unclassified_Acratocnus : Acratocnus, Iunclassified_Acratocnus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Acratocnus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2648349;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Acratocnus";
}
