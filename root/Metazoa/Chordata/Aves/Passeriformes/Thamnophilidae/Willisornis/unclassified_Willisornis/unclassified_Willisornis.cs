using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thamnophilidae.Willisornis;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thamnophilidae.Willisornis.unclassified_Willisornis;

/// <summary>
/// Abstract class for unclassified Willisornis (no rank).
/// NCBI TaxId: 2623965
/// </summary>
public abstract class unclassified_Willisornis : Willisornis, Iunclassified_Willisornis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Willisornis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2623965;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Willisornis";
}
