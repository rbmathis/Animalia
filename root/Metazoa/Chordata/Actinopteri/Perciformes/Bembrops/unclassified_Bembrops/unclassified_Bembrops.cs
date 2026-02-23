using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Bembrops;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Bembrops.unclassified_Bembrops;

/// <summary>
/// Abstract class for unclassified Bembrops (no rank).
/// NCBI TaxId: 2643824
/// </summary>
public abstract class unclassified_Bembrops : Bembrops, Iunclassified_Bembrops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Bembrops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2643824;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Bembrops";
}
