using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pipridae.Manacus;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pipridae.Manacus.unclassified_Manacus;

/// <summary>
/// Abstract class for unclassified Manacus (no rank).
/// NCBI TaxId: 2990454
/// </summary>
public abstract class unclassified_Manacus : Manacus, Iunclassified_Manacus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Manacus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2990454;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Manacus";
}
