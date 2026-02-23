using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Trichomycteridae.Paravandellia;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Trichomycteridae.Paravandellia.unclassified_Paravandellia;

/// <summary>
/// Abstract class for unclassified Paravandellia (no rank).
/// NCBI TaxId: 2628392
/// </summary>
public abstract class unclassified_Paravandellia : Paravandellia, Iunclassified_Paravandellia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Paravandellia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2628392;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Paravandellia";
}
