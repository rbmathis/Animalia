using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Serranidae.Liopropoma;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Serranidae.Liopropoma.unclassified_Liopropoma;

/// <summary>
/// Abstract class for unclassified Liopropoma (no rank).
/// NCBI TaxId: 2620199
/// </summary>
public abstract class unclassified_Liopropoma : Liopropoma, Iunclassified_Liopropoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Liopropoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2620199;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Liopropoma";
}
