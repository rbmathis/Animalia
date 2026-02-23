using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Bythitidae.Ogilbia;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Bythitidae.Ogilbia.unclassified_Ogilbia;

/// <summary>
/// Abstract class for unclassified Ogilbia (no rank).
/// NCBI TaxId: 2640287
/// </summary>
public abstract class unclassified_Ogilbia : Ogilbia, Iunclassified_Ogilbia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Ogilbia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2640287;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Ogilbia";
}
