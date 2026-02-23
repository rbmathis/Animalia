using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Cyprichromis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Cyprichromis.unclassified_Cyprichromis;

/// <summary>
/// Abstract class for unclassified Cyprichromis (no rank).
/// NCBI TaxId: 2640445
/// </summary>
public abstract class unclassified_Cyprichromis : Cyprichromis, Iunclassified_Cyprichromis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Cyprichromis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2640445;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Cyprichromis";
}
