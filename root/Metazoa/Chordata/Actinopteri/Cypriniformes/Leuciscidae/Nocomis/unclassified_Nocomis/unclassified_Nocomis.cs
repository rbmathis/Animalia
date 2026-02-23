using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae.Nocomis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae.Nocomis.unclassified_Nocomis;

/// <summary>
/// Abstract class for unclassified Nocomis (no rank).
/// NCBI TaxId: 2636900
/// </summary>
public abstract class unclassified_Nocomis : Nocomis, Iunclassified_Nocomis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Nocomis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2636900;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Nocomis";
}
