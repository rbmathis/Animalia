using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Sciaenochromis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Sciaenochromis.unclassified_Sciaenochromis;

/// <summary>
/// Abstract class for unclassified Sciaenochromis (no rank).
/// NCBI TaxId: 2652319
/// </summary>
public abstract class unclassified_Sciaenochromis : Sciaenochromis, Iunclassified_Sciaenochromis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Sciaenochromis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2652319;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Sciaenochromis";
}
