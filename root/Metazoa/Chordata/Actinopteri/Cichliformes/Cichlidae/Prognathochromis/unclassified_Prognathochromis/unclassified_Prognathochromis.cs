using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Prognathochromis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Prognathochromis.unclassified_Prognathochromis;

/// <summary>
/// Abstract class for unclassified Prognathochromis (no rank).
/// NCBI TaxId: 2639346
/// </summary>
public abstract class unclassified_Prognathochromis : Prognathochromis, Iunclassified_Prognathochromis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Prognathochromis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2639346;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Prognathochromis";
}
