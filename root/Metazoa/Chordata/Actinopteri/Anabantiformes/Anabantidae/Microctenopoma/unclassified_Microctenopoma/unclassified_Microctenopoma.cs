using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anabantiformes.Anabantidae.Microctenopoma;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anabantiformes.Anabantidae.Microctenopoma.unclassified_Microctenopoma;

/// <summary>
/// Abstract class for unclassified Microctenopoma (no rank).
/// NCBI TaxId: 2623075
/// </summary>
public abstract class unclassified_Microctenopoma : Microctenopoma, Iunclassified_Microctenopoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Microctenopoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2623075;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Microctenopoma";
}
