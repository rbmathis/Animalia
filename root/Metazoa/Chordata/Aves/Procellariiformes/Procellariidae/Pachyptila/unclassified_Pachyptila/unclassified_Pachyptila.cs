using AnimalKingdom.root.Metazoa.Chordata.Aves.Procellariiformes.Procellariidae.Pachyptila;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Procellariiformes.Procellariidae.Pachyptila.unclassified_Pachyptila;

/// <summary>
/// Abstract class for unclassified Pachyptila (no rank).
/// NCBI TaxId: 2648232
/// </summary>
public abstract class unclassified_Pachyptila : Pachyptila, Iunclassified_Pachyptila
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pachyptila";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2648232;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pachyptila";
}
