using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Steatocranus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Steatocranus.unclassified_Steatocranus;

/// <summary>
/// Abstract class for unclassified Steatocranus (no rank).
/// NCBI TaxId: 2631655
/// </summary>
public abstract class unclassified_Steatocranus : Steatocranus, Iunclassified_Steatocranus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Steatocranus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2631655;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Steatocranus";
}
