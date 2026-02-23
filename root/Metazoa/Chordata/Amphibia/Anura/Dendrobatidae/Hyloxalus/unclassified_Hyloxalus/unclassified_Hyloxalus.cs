using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Dendrobatidae.Hyloxalus;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Dendrobatidae.Hyloxalus.unclassified_Hyloxalus;

/// <summary>
/// Abstract class for unclassified Hyloxalus (no rank).
/// NCBI TaxId: 2623812
/// </summary>
public abstract class unclassified_Hyloxalus : Hyloxalus, Iunclassified_Hyloxalus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Hyloxalus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2623812;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Hyloxalus";
}
