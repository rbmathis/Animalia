using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Synodontidae.Synodus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Synodontidae.Synodus.unclassified_Synodus;

/// <summary>
/// Abstract class for unclassified Synodus (no rank).
/// NCBI TaxId: 2643784
/// </summary>
public abstract class unclassified_Synodus : Synodus, Iunclassified_Synodus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Synodus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2643784;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Synodus";
}
