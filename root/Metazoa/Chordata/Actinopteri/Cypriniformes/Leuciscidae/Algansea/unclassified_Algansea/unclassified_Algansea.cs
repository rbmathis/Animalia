using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae.Algansea;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae.Algansea.unclassified_Algansea;

/// <summary>
/// Abstract class for unclassified Algansea (no rank).
/// NCBI TaxId: 2629878
/// </summary>
public abstract class unclassified_Algansea : Algansea, Iunclassified_Algansea
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Algansea";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2629878;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Algansea";
}
