using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Chaetobranchopsis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Chaetobranchopsis.unclassified_Chaetobranchopsis;

/// <summary>
/// Abstract class for unclassified Chaetobranchopsis (no rank).
/// NCBI TaxId: 2710733
/// </summary>
public abstract class unclassified_Chaetobranchopsis : Chaetobranchopsis, Iunclassified_Chaetobranchopsis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Chaetobranchopsis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2710733;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Chaetobranchopsis";
}
