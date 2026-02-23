using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Teiidae.Salvator;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Teiidae.Salvator.unclassified_Salvator;

/// <summary>
/// Abstract class for unclassified Salvator (no rank).
/// NCBI TaxId: 2641844
/// </summary>
public abstract class unclassified_Salvator : Salvator, Iunclassified_Salvator
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Salvator";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2641844;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Salvator";
}
