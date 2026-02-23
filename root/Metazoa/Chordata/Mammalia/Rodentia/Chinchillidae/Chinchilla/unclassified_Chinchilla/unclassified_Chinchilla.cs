using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Chinchillidae.Chinchilla;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Chinchillidae.Chinchilla.unclassified_Chinchilla;

/// <summary>
/// Abstract class for unclassified Chinchilla (no rank).
/// NCBI TaxId: 2620208
/// </summary>
public abstract class unclassified_Chinchilla : Chinchilla, Iunclassified_Chinchilla
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Chinchilla";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2620208;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Chinchilla";
}
