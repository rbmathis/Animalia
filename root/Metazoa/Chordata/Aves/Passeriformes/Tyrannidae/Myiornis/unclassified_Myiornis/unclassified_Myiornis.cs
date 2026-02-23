using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Myiornis;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Myiornis.unclassified_Myiornis;

/// <summary>
/// Abstract class for unclassified Myiornis (no rank).
/// NCBI TaxId: 2765290
/// </summary>
public abstract class unclassified_Myiornis : Myiornis, Iunclassified_Myiornis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Myiornis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2765290;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Myiornis";
}
