using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lampriformes;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lampriformes.unclassified_Lampriformes;

/// <summary>
/// Abstract class for unclassified Lampriformes (no rank).
/// NCBI TaxId: 726001
/// </summary>
public abstract class unclassified_Lampriformes : Lampriformes, Iunclassified_Lampriformes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Lampriformes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 726001;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Lampriformes";
}
