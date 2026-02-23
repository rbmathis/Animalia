using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Ophichthidae.Lamnostoma;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Ophichthidae.Lamnostoma.unclassified_Lamnostoma;

/// <summary>
/// Abstract class for unclassified Lamnostoma (no rank).
/// NCBI TaxId: 2645025
/// </summary>
public abstract class unclassified_Lamnostoma : Lamnostoma, Iunclassified_Lamnostoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Lamnostoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2645025;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Lamnostoma";
}
