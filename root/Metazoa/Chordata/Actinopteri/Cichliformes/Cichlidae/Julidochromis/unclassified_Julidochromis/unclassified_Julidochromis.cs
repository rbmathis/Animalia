using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Julidochromis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Julidochromis.unclassified_Julidochromis;

/// <summary>
/// Abstract class for unclassified Julidochromis (no rank).
/// NCBI TaxId: 2647804
/// </summary>
public abstract class unclassified_Julidochromis : Julidochromis, Iunclassified_Julidochromis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Julidochromis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2647804;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Julidochromis";
}
