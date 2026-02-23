using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Kurtiformes.Apogonidae.Ostorhinchus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Kurtiformes.Apogonidae.Ostorhinchus.unclassified_Ostorhinchus;

/// <summary>
/// Abstract class for unclassified Ostorhinchus (no rank).
/// NCBI TaxId: 2644708
/// </summary>
public abstract class unclassified_Ostorhinchus : Ostorhinchus, Iunclassified_Ostorhinchus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Ostorhinchus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2644708;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Ostorhinchus";
}
