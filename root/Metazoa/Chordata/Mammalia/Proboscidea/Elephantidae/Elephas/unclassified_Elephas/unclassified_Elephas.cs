using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Proboscidea.Elephantidae.Elephas;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Proboscidea.Elephantidae.Elephas.unclassified_Elephas;

/// <summary>
/// Abstract class for unclassified Elephas (no rank).
/// NCBI TaxId: 2618891
/// </summary>
public abstract class unclassified_Elephas : Elephas, Iunclassified_Elephas
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Elephas";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2618891;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Elephas";
}
