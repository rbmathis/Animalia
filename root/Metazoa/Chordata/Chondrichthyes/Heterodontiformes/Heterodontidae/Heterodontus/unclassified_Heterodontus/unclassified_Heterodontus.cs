using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Heterodontiformes.Heterodontidae.Heterodontus;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Heterodontiformes.Heterodontidae.Heterodontus.unclassified_Heterodontus;

/// <summary>
/// Abstract class for unclassified Heterodontus (no rank).
/// NCBI TaxId: 2634937
/// </summary>
public abstract class unclassified_Heterodontus : Heterodontus, Iunclassified_Heterodontus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Heterodontus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2634937;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Heterodontus";
}
