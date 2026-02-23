using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Stevardiidae.Mimagoniates;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Stevardiidae.Mimagoniates.unclassified_Mimagoniates;

/// <summary>
/// Abstract class for unclassified Mimagoniates (no rank).
/// NCBI TaxId: 2685471
/// </summary>
public abstract class unclassified_Mimagoniates : Mimagoniates, Iunclassified_Mimagoniates
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Mimagoniates";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2685471;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Mimagoniates";
}
