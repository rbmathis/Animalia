using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Kurtiformes.Apogonidae.Nectamia;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Kurtiformes.Apogonidae.Nectamia.unclassified_Nectamia;

/// <summary>
/// Abstract class for unclassified Nectamia (no rank).
/// NCBI TaxId: 2965666
/// </summary>
public abstract class unclassified_Nectamia : Nectamia, Iunclassified_Nectamia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Nectamia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2965666;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Nectamia";
}
