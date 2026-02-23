using AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Rallidae.Laterallus;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Rallidae.Laterallus.unclassified_Laterallus;

/// <summary>
/// Abstract class for unclassified Laterallus (no rank).
/// NCBI TaxId: 2878416
/// </summary>
public abstract class unclassified_Laterallus : Laterallus, Iunclassified_Laterallus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Laterallus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2878416;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Laterallus";
}
