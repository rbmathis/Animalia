using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Mochokidae.Atopochilus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Mochokidae.Atopochilus.unclassified_Atopochilus;

/// <summary>
/// Abstract class for unclassified Atopochilus (no rank).
/// NCBI TaxId: 2630627
/// </summary>
public abstract class unclassified_Atopochilus : Atopochilus, Iunclassified_Atopochilus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Atopochilus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2630627;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Atopochilus";
}
