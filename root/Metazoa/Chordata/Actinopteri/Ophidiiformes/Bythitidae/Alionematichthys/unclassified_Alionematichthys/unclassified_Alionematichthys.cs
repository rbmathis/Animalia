using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Bythitidae.Alionematichthys;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Bythitidae.Alionematichthys.unclassified_Alionematichthys;

/// <summary>
/// Abstract class for unclassified Alionematichthys (no rank).
/// NCBI TaxId: 2646436
/// </summary>
public abstract class unclassified_Alionematichthys : Alionematichthys, Iunclassified_Alionematichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Alionematichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2646436;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Alionematichthys";
}
