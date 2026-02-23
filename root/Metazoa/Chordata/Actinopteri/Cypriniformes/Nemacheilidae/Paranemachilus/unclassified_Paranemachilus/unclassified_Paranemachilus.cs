using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Nemacheilidae.Paranemachilus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Nemacheilidae.Paranemachilus.unclassified_Paranemachilus;

/// <summary>
/// Abstract class for unclassified Paranemachilus (no rank).
/// NCBI TaxId: 2849535
/// </summary>
public abstract class unclassified_Paranemachilus : Paranemachilus, Iunclassified_Paranemachilus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Paranemachilus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2849535;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Paranemachilus";
}
