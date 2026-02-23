using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Parananochromis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Parananochromis.unclassified_Parananochromis;

/// <summary>
/// Abstract class for unclassified Parananochromis (no rank).
/// NCBI TaxId: 2627000
/// </summary>
public abstract class unclassified_Parananochromis : Parananochromis, Iunclassified_Parananochromis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Parananochromis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2627000;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Parananochromis";
}
