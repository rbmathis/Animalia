using AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.unclassified_Gruiformes;

/// <summary>
/// Abstract class for unclassified Gruiformes (no rank).
/// NCBI TaxId: 791207
/// </summary>
public abstract class unclassified_Gruiformes : Gruiformes, Iunclassified_Gruiformes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Gruiformes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 791207;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Gruiformes";
}
