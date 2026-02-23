using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Abrothrix;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Abrothrix.unclassified_Abrothrix;

/// <summary>
/// Abstract class for unclassified Abrothrix (no rank).
/// NCBI TaxId: 2648388
/// </summary>
public abstract class unclassified_Abrothrix : Abrothrix, Iunclassified_Abrothrix
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Abrothrix";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2648388;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Abrothrix";
}
