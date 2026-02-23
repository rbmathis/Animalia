using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Istiophoriformes.Istiophoridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Istiophoriformes.Istiophoridae.unclassified_Istiophoridae;

/// <summary>
/// Abstract class for unclassified Istiophoridae (no rank).
/// NCBI TaxId: 2735073
/// </summary>
public abstract class unclassified_Istiophoridae : Istiophoridae, Iunclassified_Istiophoridae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Istiophoridae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2735073;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Istiophoridae";
}
