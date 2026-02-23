using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osmeriformes.Salangidae.Salanx;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osmeriformes.Salangidae.Salanx.unclassified_Salanx;

/// <summary>
/// Abstract class for unclassified Salanx (no rank).
/// NCBI TaxId: 3074029
/// </summary>
public abstract class unclassified_Salanx : Salanx, Iunclassified_Salanx
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Salanx";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3074029;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Salanx";
}
