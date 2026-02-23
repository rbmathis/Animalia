using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Ctenochromis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Ctenochromis.unclassified_Ctenochromis;

/// <summary>
/// Abstract class for unclassified Ctenochromis (no rank).
/// NCBI TaxId: 2912964
/// </summary>
public abstract class unclassified_Ctenochromis : Ctenochromis, Iunclassified_Ctenochromis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Ctenochromis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2912964;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Ctenochromis";
}
