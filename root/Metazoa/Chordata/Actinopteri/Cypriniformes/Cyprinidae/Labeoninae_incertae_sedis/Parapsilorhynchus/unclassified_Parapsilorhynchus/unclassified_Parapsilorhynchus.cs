using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Labeoninae_incertae_sedis.Parapsilorhynchus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Labeoninae_incertae_sedis.Parapsilorhynchus.unclassified_Parapsilorhynchus;

/// <summary>
/// Abstract class for unclassified Parapsilorhynchus (no rank).
/// NCBI TaxId: 2644451
/// </summary>
public abstract class unclassified_Parapsilorhynchus : Parapsilorhynchus, Iunclassified_Parapsilorhynchus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Parapsilorhynchus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2644451;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Parapsilorhynchus";
}
