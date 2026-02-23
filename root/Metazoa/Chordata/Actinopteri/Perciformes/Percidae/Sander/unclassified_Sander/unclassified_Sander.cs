using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Percidae.Sander;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Percidae.Sander.unclassified_Sander;

/// <summary>
/// Abstract class for unclassified Sander (no rank).
/// NCBI TaxId: 2636696
/// </summary>
public abstract class unclassified_Sander : Sander, Iunclassified_Sander
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Sander";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2636696;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Sander";
}
