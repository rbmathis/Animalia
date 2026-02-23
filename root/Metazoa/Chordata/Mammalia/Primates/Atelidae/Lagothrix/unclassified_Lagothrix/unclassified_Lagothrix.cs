using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Atelidae.Lagothrix;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Atelidae.Lagothrix.unclassified_Lagothrix;

/// <summary>
/// Abstract class for unclassified Lagothrix (no rank).
/// NCBI TaxId: 2645779
/// </summary>
public abstract class unclassified_Lagothrix : Lagothrix, Iunclassified_Lagothrix
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Lagothrix";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2645779;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Lagothrix";
}
