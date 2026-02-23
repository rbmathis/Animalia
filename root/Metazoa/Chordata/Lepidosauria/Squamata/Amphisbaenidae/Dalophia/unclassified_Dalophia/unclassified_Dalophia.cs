using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Amphisbaenidae.Dalophia;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Amphisbaenidae.Dalophia.unclassified_Dalophia;

/// <summary>
/// Abstract class for unclassified Dalophia (no rank).
/// NCBI TaxId: 2642780
/// </summary>
public abstract class unclassified_Dalophia : Dalophia, Iunclassified_Dalophia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Dalophia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2642780;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Dalophia";
}
