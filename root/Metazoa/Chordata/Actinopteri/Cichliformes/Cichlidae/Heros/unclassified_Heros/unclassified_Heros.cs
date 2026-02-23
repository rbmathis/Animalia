using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Heros;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Heros.unclassified_Heros;

/// <summary>
/// Abstract class for unclassified Heros (no rank).
/// NCBI TaxId: 2623125
/// </summary>
public abstract class unclassified_Heros : Heros, Iunclassified_Heros
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Heros";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2623125;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Heros";
}
