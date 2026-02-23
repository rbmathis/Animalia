using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Sinipercidae.Siniperca;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Sinipercidae.Siniperca.unclassified_Siniperca;

/// <summary>
/// Abstract class for unclassified Siniperca (no rank).
/// NCBI TaxId: 2640743
/// </summary>
public abstract class unclassified_Siniperca : Siniperca, Iunclassified_Siniperca
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Siniperca";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2640743;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Siniperca";
}
