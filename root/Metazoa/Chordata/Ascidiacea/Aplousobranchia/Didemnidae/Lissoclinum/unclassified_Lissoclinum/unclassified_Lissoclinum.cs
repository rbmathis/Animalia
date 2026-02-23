using AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Aplousobranchia.Didemnidae.Lissoclinum;

namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Aplousobranchia.Didemnidae.Lissoclinum.unclassified_Lissoclinum;

/// <summary>
/// Abstract class for unclassified Lissoclinum (no rank).
/// NCBI TaxId: 2633725
/// </summary>
public abstract class unclassified_Lissoclinum : Lissoclinum, Iunclassified_Lissoclinum
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Lissoclinum";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2633725;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Lissoclinum";
}
