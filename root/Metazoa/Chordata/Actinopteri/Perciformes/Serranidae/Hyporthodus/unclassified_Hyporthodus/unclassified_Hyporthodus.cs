using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Serranidae.Hyporthodus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Serranidae.Hyporthodus.unclassified_Hyporthodus;

/// <summary>
/// Abstract class for unclassified Hyporthodus (no rank).
/// NCBI TaxId: 2649375
/// </summary>
public abstract class unclassified_Hyporthodus : Hyporthodus, Iunclassified_Hyporthodus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Hyporthodus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2649375;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Hyporthodus";
}
