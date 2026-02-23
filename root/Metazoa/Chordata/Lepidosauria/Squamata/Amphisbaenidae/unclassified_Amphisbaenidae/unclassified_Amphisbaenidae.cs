using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Amphisbaenidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Amphisbaenidae.unclassified_Amphisbaenidae;

/// <summary>
/// Abstract class for unclassified Amphisbaenidae (no rank).
/// NCBI TaxId: 1214351
/// </summary>
public abstract class unclassified_Amphisbaenidae : Amphisbaenidae, Iunclassified_Amphisbaenidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Amphisbaenidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1214351;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Amphisbaenidae";
}
