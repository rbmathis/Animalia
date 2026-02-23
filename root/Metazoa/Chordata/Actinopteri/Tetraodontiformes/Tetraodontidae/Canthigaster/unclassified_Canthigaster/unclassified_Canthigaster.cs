using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Tetraodontidae.Canthigaster;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Tetraodontidae.Canthigaster.unclassified_Canthigaster;

/// <summary>
/// Abstract class for unclassified Canthigaster (no rank).
/// NCBI TaxId: 2743689
/// </summary>
public abstract class unclassified_Canthigaster : Canthigaster, Iunclassified_Canthigaster
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Canthigaster";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2743689;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Canthigaster";
}
