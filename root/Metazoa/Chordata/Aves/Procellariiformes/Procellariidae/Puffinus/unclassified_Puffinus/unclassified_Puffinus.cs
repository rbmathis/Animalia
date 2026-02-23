using AnimalKingdom.root.Metazoa.Chordata.Aves.Procellariiformes.Procellariidae.Puffinus;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Procellariiformes.Procellariidae.Puffinus.unclassified_Puffinus;

/// <summary>
/// Abstract class for unclassified Puffinus (no rank).
/// NCBI TaxId: 2638476
/// </summary>
public abstract class unclassified_Puffinus : Puffinus, Iunclassified_Puffinus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Puffinus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2638476;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Puffinus";
}
