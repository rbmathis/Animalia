using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beloniformes.Exocoetidae.Prognichthys;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beloniformes.Exocoetidae.Prognichthys.unclassified_Prognichthys;

/// <summary>
/// Abstract class for unclassified Prognichthys (no rank).
/// NCBI TaxId: 2629842
/// </summary>
public abstract class unclassified_Prognichthys : Prognichthys, Iunclassified_Prognichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Prognichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2629842;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Prognichthys";
}
