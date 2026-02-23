using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Chamaeleonidae.Calumma;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Chamaeleonidae.Calumma.unclassified_Calumma;

/// <summary>
/// Abstract class for unclassified Calumma (no rank).
/// NCBI TaxId: 2621689
/// </summary>
public abstract class unclassified_Calumma : Calumma, Iunclassified_Calumma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Calumma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2621689;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Calumma";
}
