using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Thoracochromis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Thoracochromis.unclassified_Thoracochromis;

/// <summary>
/// Abstract class for unclassified Thoracochromis (no rank).
/// NCBI TaxId: 2624228
/// </summary>
public abstract class unclassified_Thoracochromis : Thoracochromis, Iunclassified_Thoracochromis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Thoracochromis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2624228;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Thoracochromis";
}
