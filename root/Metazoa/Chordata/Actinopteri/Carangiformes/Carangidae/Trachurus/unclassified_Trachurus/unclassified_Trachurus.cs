using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangiformes.Carangidae.Trachurus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangiformes.Carangidae.Trachurus.unclassified_Trachurus;

/// <summary>
/// Abstract class for unclassified Trachurus (no rank).
/// NCBI TaxId: 2618721
/// </summary>
public abstract class unclassified_Trachurus : Trachurus, Iunclassified_Trachurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Trachurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2618721;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Trachurus";
}
