using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Paracheilinus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Paracheilinus.unclassified_Paracheilinus;

/// <summary>
/// Abstract class for unclassified Paracheilinus (no rank).
/// NCBI TaxId: 2640717
/// </summary>
public abstract class unclassified_Paracheilinus : Paracheilinus, Iunclassified_Paracheilinus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Paracheilinus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2640717;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Paracheilinus";
}
