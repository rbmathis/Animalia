using AnimalKingdom.root.Metazoa.Chordata.Aves.Cuculiformes;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Cuculiformes.unclassified_Cuculiformes;

/// <summary>
/// Abstract class for unclassified Cuculiformes (no rank).
/// NCBI TaxId: 791191
/// </summary>
public abstract class unclassified_Cuculiformes : Cuculiformes, Iunclassified_Cuculiformes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Cuculiformes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 791191;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Cuculiformes";
}
