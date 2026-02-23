using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Gasteropelecidae.Carnegiella;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Gasteropelecidae.Carnegiella.unclassified_Carnegiella;

/// <summary>
/// Abstract class for unclassified Carnegiella (no rank).
/// NCBI TaxId: 2627453
/// </summary>
public abstract class unclassified_Carnegiella : Carnegiella, Iunclassified_Carnegiella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Carnegiella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2627453;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Carnegiella";
}
