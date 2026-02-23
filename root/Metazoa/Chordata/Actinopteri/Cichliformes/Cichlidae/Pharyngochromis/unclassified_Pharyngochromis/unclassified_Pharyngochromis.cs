using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Pharyngochromis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Pharyngochromis.unclassified_Pharyngochromis;

/// <summary>
/// Abstract class for unclassified Pharyngochromis (no rank).
/// NCBI TaxId: 2622507
/// </summary>
public abstract class unclassified_Pharyngochromis : Pharyngochromis, Iunclassified_Pharyngochromis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pharyngochromis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2622507;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pharyngochromis";
}
