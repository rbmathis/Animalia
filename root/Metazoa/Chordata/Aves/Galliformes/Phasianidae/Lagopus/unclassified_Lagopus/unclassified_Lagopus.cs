using AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae.Lagopus;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae.Lagopus.unclassified_Lagopus;

/// <summary>
/// Abstract class for unclassified Lagopus (no rank).
/// NCBI TaxId: 2933281
/// </summary>
public abstract class unclassified_Lagopus : Lagopus, Iunclassified_Lagopus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Lagopus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2933281;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Lagopus";
}
