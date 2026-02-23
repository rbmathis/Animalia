using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Congridae.Gorgasia;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Congridae.Gorgasia.unclassified_Gorgasia;

/// <summary>
/// Abstract class for unclassified Gorgasia (no rank).
/// NCBI TaxId: 2643169
/// </summary>
public abstract class unclassified_Gorgasia : Gorgasia, Iunclassified_Gorgasia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Gorgasia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2643169;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Gorgasia";
}
