using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Diprotodontia.Macropodidae.Macropus;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Diprotodontia.Macropodidae.Macropus.unclassified_Macropus;

/// <summary>
/// Abstract class for unclassified Macropus (no rank).
/// NCBI TaxId: 2649300
/// </summary>
public abstract class unclassified_Macropus : Macropus, Iunclassified_Macropus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Macropus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2649300;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Macropus";
}
