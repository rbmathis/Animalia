using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Elopiformes.Elopidae.Elops;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Elopiformes.Elopidae.Elops.unclassified_Elops;

/// <summary>
/// Abstract class for unclassified Elops (no rank).
/// NCBI TaxId: 2621588
/// </summary>
public abstract class unclassified_Elops : Elops, Iunclassified_Elops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Elops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2621588;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Elops";
}
