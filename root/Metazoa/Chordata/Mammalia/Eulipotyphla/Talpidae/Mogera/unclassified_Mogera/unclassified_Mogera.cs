using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Talpidae.Mogera;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Talpidae.Mogera.unclassified_Mogera;

/// <summary>
/// Abstract class for unclassified Mogera (no rank).
/// NCBI TaxId: 281285
/// </summary>
public abstract class unclassified_Mogera : Mogera, Iunclassified_Mogera
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Mogera";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 281285;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Mogera";
}
