using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Mochokidae.Atopodontus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Mochokidae.Atopodontus.unclassified_Atopodontus;

/// <summary>
/// Abstract class for unclassified Atopodontus (no rank).
/// NCBI TaxId: 3023577
/// </summary>
public abstract class unclassified_Atopodontus : Atopodontus, Iunclassified_Atopodontus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Atopodontus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3023577;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Atopodontus";
}
