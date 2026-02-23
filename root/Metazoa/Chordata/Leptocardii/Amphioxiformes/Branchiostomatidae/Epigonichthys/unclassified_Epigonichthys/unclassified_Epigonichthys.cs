using AnimalKingdom.root.Metazoa.Chordata.Leptocardii.Amphioxiformes.Branchiostomatidae.Epigonichthys;

namespace AnimalKingdom.root.Metazoa.Chordata.Leptocardii.Amphioxiformes.Branchiostomatidae.Epigonichthys.unclassified_Epigonichthys;

/// <summary>
/// Abstract class for unclassified Epigonichthys (no rank).
/// NCBI TaxId: 3045410
/// </summary>
public abstract class unclassified_Epigonichthys : Epigonichthys, Iunclassified_Epigonichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Epigonichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3045410;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Epigonichthys";
}
