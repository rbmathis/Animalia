using AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae.Phasianus;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae.Phasianus.unclassified_Phasianus;

/// <summary>
/// Abstract class for unclassified Phasianus (no rank).
/// NCBI TaxId: 2631862
/// </summary>
public abstract class unclassified_Phasianus : Phasianus, Iunclassified_Phasianus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Phasianus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2631862;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Phasianus";
}
