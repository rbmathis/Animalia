using AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae.Gallus;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae.Gallus.unclassified_Gallus;

/// <summary>
/// Abstract class for unclassified Gallus (no rank).
/// NCBI TaxId: 2633162
/// </summary>
public abstract class unclassified_Gallus : Gallus, Iunclassified_Gallus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Gallus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2633162;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Gallus";
}
