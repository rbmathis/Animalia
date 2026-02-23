using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Eleotridae.Bostrychus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Eleotridae.Bostrychus.unclassified_Bostrychus;

/// <summary>
/// Abstract class for unclassified Bostrychus (no rank).
/// NCBI TaxId: 3037309
/// </summary>
public abstract class unclassified_Bostrychus : Bostrychus, Iunclassified_Bostrychus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Bostrychus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3037309;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Bostrychus";
}
