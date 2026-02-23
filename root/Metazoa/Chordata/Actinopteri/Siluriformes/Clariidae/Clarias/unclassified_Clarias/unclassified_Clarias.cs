using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Clariidae.Clarias;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Clariidae.Clarias.unclassified_Clarias;

/// <summary>
/// Abstract class for unclassified Clarias (no rank).
/// NCBI TaxId: 2636492
/// </summary>
public abstract class unclassified_Clarias : Clarias, Iunclassified_Clarias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Clarias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2636492;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Clarias";
}
