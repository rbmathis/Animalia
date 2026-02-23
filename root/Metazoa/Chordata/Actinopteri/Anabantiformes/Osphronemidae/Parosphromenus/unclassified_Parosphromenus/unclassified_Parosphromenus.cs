using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anabantiformes.Osphronemidae.Parosphromenus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anabantiformes.Osphronemidae.Parosphromenus.unclassified_Parosphromenus;

/// <summary>
/// Abstract class for unclassified Parosphromenus (no rank).
/// NCBI TaxId: 2873979
/// </summary>
public abstract class unclassified_Parosphromenus : Parosphromenus, Iunclassified_Parosphromenus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Parosphromenus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2873979;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Parosphromenus";
}
