using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Paridae.Poecile;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Paridae.Poecile.unclassified_Poecile;

/// <summary>
/// Abstract class for unclassified Poecile (no rank).
/// NCBI TaxId: 2980466
/// </summary>
public abstract class unclassified_Poecile : Poecile, Iunclassified_Poecile
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Poecile";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2980466;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Poecile";
}
