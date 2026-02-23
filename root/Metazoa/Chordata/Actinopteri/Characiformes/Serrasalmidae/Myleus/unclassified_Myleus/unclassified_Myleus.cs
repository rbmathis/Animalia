using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Serrasalmidae.Myleus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Serrasalmidae.Myleus.unclassified_Myleus;

/// <summary>
/// Abstract class for unclassified Myleus (no rank).
/// NCBI TaxId: 2647786
/// </summary>
public abstract class unclassified_Myleus : Myleus, Iunclassified_Myleus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Myleus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2647786;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Myleus";
}
