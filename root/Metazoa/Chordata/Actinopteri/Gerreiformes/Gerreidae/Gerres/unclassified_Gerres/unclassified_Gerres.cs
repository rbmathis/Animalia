using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gerreiformes.Gerreidae.Gerres;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gerreiformes.Gerreidae.Gerres.unclassified_Gerres;

/// <summary>
/// Abstract class for unclassified Gerres (no rank).
/// NCBI TaxId: 2672442
/// </summary>
public abstract class unclassified_Gerres : Gerres, Iunclassified_Gerres
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Gerres";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2672442;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Gerres";
}
