using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Psilorhynchidae.Psilorhynchus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Psilorhynchidae.Psilorhynchus.unclassified_Psilorhynchus;

/// <summary>
/// Abstract class for unclassified Psilorhynchus (no rank).
/// NCBI TaxId: 2629366
/// </summary>
public abstract class unclassified_Psilorhynchus : Psilorhynchus, Iunclassified_Psilorhynchus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Psilorhynchus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2629366;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Psilorhynchus";
}
