using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae.Riama;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae.Riama.unclassified_Riama;

/// <summary>
/// Abstract class for unclassified Riama (no rank).
/// NCBI TaxId: 2620564
/// </summary>
public abstract class unclassified_Riama : Riama, Iunclassified_Riama
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Riama";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2620564;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Riama";
}
