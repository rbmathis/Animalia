using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Ploceidae.Ploceus;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Ploceidae.Ploceus.unclassified_Ploceus;

/// <summary>
/// Abstract class for unclassified Ploceus (no rank).
/// NCBI TaxId: 2629784
/// </summary>
public abstract class unclassified_Ploceus : Ploceus, Iunclassified_Ploceus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Ploceus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2629784;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Ploceus";
}
