using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Sternoptychidae.Polyipnus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Sternoptychidae.Polyipnus.unclassified_Polyipnus;

/// <summary>
/// Abstract class for unclassified Polyipnus (no rank).
/// NCBI TaxId: 2634295
/// </summary>
public abstract class unclassified_Polyipnus : Polyipnus, Iunclassified_Polyipnus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Polyipnus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2634295;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Polyipnus";
}
