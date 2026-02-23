using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Melanochromis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Melanochromis.unclassified_Melanochromis;

/// <summary>
/// Abstract class for unclassified Melanochromis (no rank).
/// NCBI TaxId: 2621801
/// </summary>
public abstract class unclassified_Melanochromis : Melanochromis, Iunclassified_Melanochromis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Melanochromis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2621801;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Melanochromis";
}
