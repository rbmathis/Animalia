using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Bythitidae.Dinematichthys;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Bythitidae.Dinematichthys.unclassified_Dinematichthys;

/// <summary>
/// Abstract class for unclassified Dinematichthys (no rank).
/// NCBI TaxId: 3444650
/// </summary>
public abstract class unclassified_Dinematichthys : Dinematichthys, Iunclassified_Dinematichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Dinematichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3444650;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Dinematichthys";
}
