using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Clariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Clariidae.unclassified_Clariidae;

/// <summary>
/// Abstract class for unclassified Clariidae (no rank).
/// NCBI TaxId: 1185504
/// </summary>
public abstract class unclassified_Clariidae : Clariidae, Iunclassified_Clariidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Clariidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1185504;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Clariidae";
}
