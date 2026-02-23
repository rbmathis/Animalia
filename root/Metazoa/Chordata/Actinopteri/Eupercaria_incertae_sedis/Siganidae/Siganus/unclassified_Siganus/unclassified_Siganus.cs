using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Siganidae.Siganus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Siganidae.Siganus.unclassified_Siganus;

/// <summary>
/// Abstract class for unclassified Siganus (no rank).
/// NCBI TaxId: 2634005
/// </summary>
public abstract class unclassified_Siganus : Siganus, Iunclassified_Siganus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Siganus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2634005;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Siganus";
}
