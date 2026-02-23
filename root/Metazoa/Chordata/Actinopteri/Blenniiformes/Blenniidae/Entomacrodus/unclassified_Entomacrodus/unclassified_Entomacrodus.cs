using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Blenniidae.Entomacrodus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Blenniidae.Entomacrodus.unclassified_Entomacrodus;

/// <summary>
/// Abstract class for unclassified Entomacrodus (no rank).
/// NCBI TaxId: 2630364
/// </summary>
public abstract class unclassified_Entomacrodus : Entomacrodus, Iunclassified_Entomacrodus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Entomacrodus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2630364;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Entomacrodus";
}
