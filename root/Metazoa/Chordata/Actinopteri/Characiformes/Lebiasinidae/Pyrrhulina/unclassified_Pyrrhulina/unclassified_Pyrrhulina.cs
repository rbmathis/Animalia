using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Lebiasinidae.Pyrrhulina;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Lebiasinidae.Pyrrhulina.unclassified_Pyrrhulina;

/// <summary>
/// Abstract class for unclassified Pyrrhulina (no rank).
/// NCBI TaxId: 2608185
/// </summary>
public abstract class unclassified_Pyrrhulina : Pyrrhulina, Iunclassified_Pyrrhulina
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pyrrhulina";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2608185;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pyrrhulina";
}
