using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Sebastidae.Helicolenus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Sebastidae.Helicolenus.unclassified_Helicolenus;

/// <summary>
/// Abstract class for unclassified Helicolenus (no rank).
/// NCBI TaxId: 2641758
/// </summary>
public abstract class unclassified_Helicolenus : Helicolenus, Iunclassified_Helicolenus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Helicolenus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2641758;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Helicolenus";
}
