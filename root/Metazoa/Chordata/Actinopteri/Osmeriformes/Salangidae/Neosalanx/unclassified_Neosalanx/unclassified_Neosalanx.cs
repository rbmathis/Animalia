using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osmeriformes.Salangidae.Neosalanx;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osmeriformes.Salangidae.Neosalanx.unclassified_Neosalanx;

/// <summary>
/// Abstract class for unclassified Neosalanx (no rank).
/// NCBI TaxId: 2640672
/// </summary>
public abstract class unclassified_Neosalanx : Neosalanx, Iunclassified_Neosalanx
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Neosalanx";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2640672;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Neosalanx";
}
