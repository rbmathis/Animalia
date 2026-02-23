using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Stevardiidae.Planaltina;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Stevardiidae.Planaltina.unclassified_Planaltina;

/// <summary>
/// Abstract class for unclassified Planaltina (no rank).
/// NCBI TaxId: 2640358
/// </summary>
public abstract class unclassified_Planaltina : Planaltina, Iunclassified_Planaltina
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Planaltina";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2640358;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Planaltina";
}
