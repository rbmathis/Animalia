using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beryciformes.Melamphaidae.Melamphaes;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beryciformes.Melamphaidae.Melamphaes.unclassified_Melamphaes;

/// <summary>
/// Abstract class for unclassified Melamphaes (no rank).
/// NCBI TaxId: 2630892
/// </summary>
public abstract class unclassified_Melamphaes : Melamphaes, Iunclassified_Melamphaes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Melamphaes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2630892;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Melamphaes";
}
