using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae.Alopoglossus;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae.Alopoglossus.unclassified_Alopoglossus;

/// <summary>
/// Abstract class for unclassified Alopoglossus (no rank).
/// NCBI TaxId: 2974548
/// </summary>
public abstract class unclassified_Alopoglossus : Alopoglossus, Iunclassified_Alopoglossus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Alopoglossus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2974548;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Alopoglossus";
}
