using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acipenseriformes.Acipenseridae.Acipenser;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acipenseriformes.Acipenseridae.Acipenser.unclassified_Acipenser;

/// <summary>
/// Abstract class for unclassified Acipenser (no rank).
/// NCBI TaxId: 2649592
/// </summary>
public abstract class unclassified_Acipenser : Acipenser, Iunclassified_Acipenser
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Acipenser";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2649592;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Acipenser";
}
