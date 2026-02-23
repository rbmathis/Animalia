using AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae.Coturnix;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae.Coturnix.unclassified_Coturnix;

/// <summary>
/// Abstract class for unclassified Coturnix (no rank).
/// NCBI TaxId: 2509466
/// </summary>
public abstract class unclassified_Coturnix : Coturnix, Iunclassified_Coturnix
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Coturnix";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2509466;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Coturnix";
}
