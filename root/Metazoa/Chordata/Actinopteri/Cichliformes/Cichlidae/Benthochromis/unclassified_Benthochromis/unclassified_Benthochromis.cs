using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Benthochromis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Benthochromis.unclassified_Benthochromis;

/// <summary>
/// Abstract class for unclassified Benthochromis (no rank).
/// NCBI TaxId: 2627631
/// </summary>
public abstract class unclassified_Benthochromis : Benthochromis, Iunclassified_Benthochromis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Benthochromis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2627631;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Benthochromis";
}
