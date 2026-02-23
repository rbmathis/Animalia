using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Congridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Congridae.unclassified_Congridae;

/// <summary>
/// Abstract class for unclassified Congridae (no rank).
/// NCBI TaxId: 1963626
/// </summary>
public abstract class unclassified_Congridae : Congridae, Iunclassified_Congridae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Congridae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1963626;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Congridae";
}
