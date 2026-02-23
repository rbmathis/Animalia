using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Siluridae.Belodontichthys;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Siluridae.Belodontichthys.unclassified_Belodontichthys;

/// <summary>
/// Abstract class for unclassified Belodontichthys (no rank).
/// NCBI TaxId: 2830587
/// </summary>
public abstract class unclassified_Belodontichthys : Belodontichthys, Iunclassified_Belodontichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Belodontichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2830587;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Belodontichthys";
}
