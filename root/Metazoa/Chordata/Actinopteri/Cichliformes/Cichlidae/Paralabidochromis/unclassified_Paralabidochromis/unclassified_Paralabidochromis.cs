using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Paralabidochromis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Paralabidochromis.unclassified_Paralabidochromis;

/// <summary>
/// Abstract class for unclassified Paralabidochromis (no rank).
/// NCBI TaxId: 2644609
/// </summary>
public abstract class unclassified_Paralabidochromis : Paralabidochromis, Iunclassified_Paralabidochromis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Paralabidochromis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2644609;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Paralabidochromis";
}
