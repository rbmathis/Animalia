using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Lithochromis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Lithochromis.unclassified_Lithochromis;

/// <summary>
/// Abstract class for unclassified Lithochromis (no rank).
/// NCBI TaxId: 2640893
/// </summary>
public abstract class unclassified_Lithochromis : Lithochromis, Iunclassified_Lithochromis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Lithochromis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2640893;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Lithochromis";
}
