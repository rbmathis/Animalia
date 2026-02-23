using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Mochokidae.Euchilichthys;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Mochokidae.Euchilichthys.unclassified_Euchilichthys;

/// <summary>
/// Abstract class for unclassified Euchilichthys (no rank).
/// NCBI TaxId: 2922154
/// </summary>
public abstract class unclassified_Euchilichthys : Euchilichthys, Iunclassified_Euchilichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Euchilichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2922154;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Euchilichthys";
}
