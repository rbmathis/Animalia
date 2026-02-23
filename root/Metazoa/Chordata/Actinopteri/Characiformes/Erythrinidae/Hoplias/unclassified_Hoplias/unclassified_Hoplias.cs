using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Erythrinidae.Hoplias;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Erythrinidae.Hoplias.unclassified_Hoplias;

/// <summary>
/// Abstract class for unclassified Hoplias (no rank).
/// NCBI TaxId: 2630474
/// </summary>
public abstract class unclassified_Hoplias : Hoplias, Iunclassified_Hoplias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Hoplias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2630474;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Hoplias";
}
