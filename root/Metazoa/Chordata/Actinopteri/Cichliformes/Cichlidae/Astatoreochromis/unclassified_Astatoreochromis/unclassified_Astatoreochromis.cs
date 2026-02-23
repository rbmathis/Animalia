using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Astatoreochromis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Astatoreochromis.unclassified_Astatoreochromis;

/// <summary>
/// Abstract class for unclassified Astatoreochromis (no rank).
/// NCBI TaxId: 2665141
/// </summary>
public abstract class unclassified_Astatoreochromis : Astatoreochromis, Iunclassified_Astatoreochromis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Astatoreochromis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2665141;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Astatoreochromis";
}
