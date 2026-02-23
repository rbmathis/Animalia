using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Hemiodontidae.Anodus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Hemiodontidae.Anodus.unclassified_Anodus;

/// <summary>
/// Abstract class for unclassified Anodus (no rank).
/// NCBI TaxId: 2710739
/// </summary>
public abstract class unclassified_Anodus : Anodus, Iunclassified_Anodus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Anodus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2710739;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Anodus";
}
