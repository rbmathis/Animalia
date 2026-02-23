using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Dasyornithidae.Dasyornis;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Dasyornithidae.Dasyornis.unclassified_Dasyornis;

/// <summary>
/// Abstract class for unclassified Dasyornis (no rank).
/// NCBI TaxId: 2630301
/// </summary>
public abstract class unclassified_Dasyornis : Dasyornis, Iunclassified_Dasyornis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Dasyornis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2630301;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Dasyornis";
}
