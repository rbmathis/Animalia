using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Gephyrochromis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Gephyrochromis.unclassified_Gephyrochromis;

/// <summary>
/// Abstract class for unclassified Gephyrochromis (no rank).
/// NCBI TaxId: 3385386
/// </summary>
public abstract class unclassified_Gephyrochromis : Gephyrochromis, Iunclassified_Gephyrochromis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Gephyrochromis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3385386;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Gephyrochromis";
}
