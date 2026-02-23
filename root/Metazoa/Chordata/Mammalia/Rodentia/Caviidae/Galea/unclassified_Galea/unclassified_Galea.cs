using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Caviidae.Galea;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Caviidae.Galea.unclassified_Galea;

/// <summary>
/// Abstract class for unclassified Galea (no rank).
/// NCBI TaxId: 2647523
/// </summary>
public abstract class unclassified_Galea : Galea, Iunclassified_Galea
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Galea";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2647523;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Galea";
}
