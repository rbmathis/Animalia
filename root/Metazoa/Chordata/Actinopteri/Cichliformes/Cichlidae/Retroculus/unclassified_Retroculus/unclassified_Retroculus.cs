using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Retroculus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Retroculus.unclassified_Retroculus;

/// <summary>
/// Abstract class for unclassified Retroculus (no rank).
/// NCBI TaxId: 2632372
/// </summary>
public abstract class unclassified_Retroculus : Retroculus, Iunclassified_Retroculus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Retroculus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2632372;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Retroculus";
}
