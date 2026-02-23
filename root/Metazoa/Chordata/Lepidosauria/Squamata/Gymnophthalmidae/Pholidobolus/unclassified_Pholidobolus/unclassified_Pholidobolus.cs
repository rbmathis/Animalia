using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae.Pholidobolus;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae.Pholidobolus.unclassified_Pholidobolus;

/// <summary>
/// Abstract class for unclassified Pholidobolus (no rank).
/// NCBI TaxId: 2626548
/// </summary>
public abstract class unclassified_Pholidobolus : Pholidobolus, Iunclassified_Pholidobolus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pholidobolus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2626548;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pholidobolus";
}
