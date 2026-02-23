using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Goodeidae.Ilyodon;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Goodeidae.Ilyodon.unclassified_Ilyodon;

/// <summary>
/// Abstract class for unclassified Ilyodon (no rank).
/// NCBI TaxId: 2617796
/// </summary>
public abstract class unclassified_Ilyodon : Ilyodon, Iunclassified_Ilyodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Ilyodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2617796;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Ilyodon";
}
