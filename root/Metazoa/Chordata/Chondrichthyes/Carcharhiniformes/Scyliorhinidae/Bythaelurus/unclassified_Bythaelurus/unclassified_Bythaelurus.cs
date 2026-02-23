using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Scyliorhinidae.Bythaelurus;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Scyliorhinidae.Bythaelurus.unclassified_Bythaelurus;

/// <summary>
/// Abstract class for unclassified Bythaelurus (no rank).
/// NCBI TaxId: 2643147
/// </summary>
public abstract class unclassified_Bythaelurus : Bythaelurus, Iunclassified_Bythaelurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Bythaelurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2643147;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Bythaelurus";
}
