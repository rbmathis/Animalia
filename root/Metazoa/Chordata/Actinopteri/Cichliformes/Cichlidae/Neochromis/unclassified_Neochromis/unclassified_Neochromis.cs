using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Neochromis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Neochromis.unclassified_Neochromis;

/// <summary>
/// Abstract class for unclassified Neochromis (no rank).
/// NCBI TaxId: 2630896
/// </summary>
public abstract class unclassified_Neochromis : Neochromis, Iunclassified_Neochromis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Neochromis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2630896;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Neochromis";
}
