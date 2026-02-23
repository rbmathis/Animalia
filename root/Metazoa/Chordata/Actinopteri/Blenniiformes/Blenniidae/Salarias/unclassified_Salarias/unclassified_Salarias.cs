using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Blenniidae.Salarias;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Blenniidae.Salarias.unclassified_Salarias;

/// <summary>
/// Abstract class for unclassified Salarias (no rank).
/// NCBI TaxId: 2626255
/// </summary>
public abstract class unclassified_Salarias : Salarias, Iunclassified_Salarias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Salarias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2626255;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Salarias";
}
