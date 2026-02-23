using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Kurtiformes.Apogonidae.Cercamia;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Kurtiformes.Apogonidae.Cercamia.unclassified_Cercamia;

/// <summary>
/// Abstract class for unclassified Cercamia (no rank).
/// NCBI TaxId: 2830869
/// </summary>
public abstract class unclassified_Cercamia : Cercamia, Iunclassified_Cercamia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Cercamia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2830869;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Cercamia";
}
