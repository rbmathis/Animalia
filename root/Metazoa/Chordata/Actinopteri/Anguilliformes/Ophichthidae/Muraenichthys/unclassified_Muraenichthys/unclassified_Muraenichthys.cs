using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Ophichthidae.Muraenichthys;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Ophichthidae.Muraenichthys.unclassified_Muraenichthys;

/// <summary>
/// Abstract class for unclassified Muraenichthys (no rank).
/// NCBI TaxId: 2624095
/// </summary>
public abstract class unclassified_Muraenichthys : Muraenichthys, Iunclassified_Muraenichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Muraenichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2624095;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Muraenichthys";
}
