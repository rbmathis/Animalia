using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Sisoridae.Pseudolaguvia;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Sisoridae.Pseudolaguvia.unclassified_Pseudolaguvia;

/// <summary>
/// Abstract class for unclassified Pseudolaguvia (no rank).
/// NCBI TaxId: 2643092
/// </summary>
public abstract class unclassified_Pseudolaguvia : Pseudolaguvia, Iunclassified_Pseudolaguvia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pseudolaguvia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2643092;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pseudolaguvia";
}
