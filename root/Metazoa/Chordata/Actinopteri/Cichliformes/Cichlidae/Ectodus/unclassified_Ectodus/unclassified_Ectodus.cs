using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Ectodus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Ectodus.unclassified_Ectodus;

/// <summary>
/// Abstract class for unclassified Ectodus (no rank).
/// NCBI TaxId: 2631314
/// </summary>
public abstract class unclassified_Ectodus : Ectodus, Iunclassified_Ectodus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Ectodus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2631314;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Ectodus";
}
