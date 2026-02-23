using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Siganidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Siganidae.unclassified_Siganidae;

/// <summary>
/// Abstract class for unclassified Siganidae (no rank).
/// NCBI TaxId: 2613824
/// </summary>
public abstract class unclassified_Siganidae : Siganidae, Iunclassified_Siganidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Siganidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2613824;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Siganidae";
}
