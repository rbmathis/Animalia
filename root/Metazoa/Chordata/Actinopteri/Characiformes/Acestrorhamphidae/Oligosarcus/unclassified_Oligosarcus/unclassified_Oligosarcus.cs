using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Acestrorhamphidae.Oligosarcus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Acestrorhamphidae.Oligosarcus.unclassified_Oligosarcus;

/// <summary>
/// Abstract class for unclassified Oligosarcus (no rank).
/// NCBI TaxId: 2632285
/// </summary>
public abstract class unclassified_Oligosarcus : Oligosarcus, Iunclassified_Oligosarcus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Oligosarcus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2632285;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Oligosarcus";
}
