using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Rhamphochromis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Rhamphochromis.unclassified_Rhamphochromis;

/// <summary>
/// Abstract class for unclassified Rhamphochromis (no rank).
/// NCBI TaxId: 2631371
/// </summary>
public abstract class unclassified_Rhamphochromis : Rhamphochromis, Iunclassified_Rhamphochromis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Rhamphochromis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2631371;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Rhamphochromis";
}
