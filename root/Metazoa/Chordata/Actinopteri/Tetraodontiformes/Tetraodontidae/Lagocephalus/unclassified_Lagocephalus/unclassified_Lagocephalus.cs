using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Tetraodontidae.Lagocephalus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Tetraodontidae.Lagocephalus.unclassified_Lagocephalus;

/// <summary>
/// Abstract class for unclassified Lagocephalus (no rank).
/// NCBI TaxId: 2626824
/// </summary>
public abstract class unclassified_Lagocephalus : Lagocephalus, Iunclassified_Lagocephalus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Lagocephalus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2626824;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Lagocephalus";
}
