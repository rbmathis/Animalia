using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Elapidae.Ophiophagus;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Elapidae.Ophiophagus.unclassified_Ophiophagus;

/// <summary>
/// Abstract class for unclassified Ophiophagus (no rank).
/// NCBI TaxId: 2638803
/// </summary>
public abstract class unclassified_Ophiophagus : Ophiophagus, Iunclassified_Ophiophagus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Ophiophagus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2638803;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Ophiophagus";
}
