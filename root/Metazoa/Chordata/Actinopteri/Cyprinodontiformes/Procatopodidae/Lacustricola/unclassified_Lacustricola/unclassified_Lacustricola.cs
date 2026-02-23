using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Procatopodidae.Lacustricola;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Procatopodidae.Lacustricola.unclassified_Lacustricola;

/// <summary>
/// Abstract class for unclassified Lacustricola (no rank).
/// NCBI TaxId: 2621207
/// </summary>
public abstract class unclassified_Lacustricola : Lacustricola, Iunclassified_Lacustricola
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Lacustricola";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2621207;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Lacustricola";
}
