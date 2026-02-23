using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Congridae.Macrocephenchelys;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Congridae.Macrocephenchelys.unclassified_Macrocephenchelys;

/// <summary>
/// Abstract class for unclassified Macrocephenchelys (no rank).
/// NCBI TaxId: 2622358
/// </summary>
public abstract class unclassified_Macrocephenchelys : Macrocephenchelys, Iunclassified_Macrocephenchelys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Macrocephenchelys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2622358;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Macrocephenchelys";
}
