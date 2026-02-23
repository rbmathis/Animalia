using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Trematocranus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Trematocranus.unclassified_Trematocranus;

/// <summary>
/// Abstract class for unclassified Trematocranus (no rank).
/// NCBI TaxId: 3390486
/// </summary>
public abstract class unclassified_Trematocranus : Trematocranus, Iunclassified_Trematocranus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Trematocranus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3390486;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Trematocranus";
}
