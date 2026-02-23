using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae.Riolama;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae.Riolama.unclassified_Riolama;

/// <summary>
/// Abstract class for unclassified Riolama (no rank).
/// NCBI TaxId: 2641703
/// </summary>
public abstract class unclassified_Riolama : Riolama, Iunclassified_Riolama
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Riolama";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2641703;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Riolama";
}
