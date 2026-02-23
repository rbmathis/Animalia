using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Kurtiformes.Apogonidae.Pterapogon;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Kurtiformes.Apogonidae.Pterapogon.unclassified_Pterapogon;

/// <summary>
/// Abstract class for unclassified Pterapogon (no rank).
/// NCBI TaxId: 2896493
/// </summary>
public abstract class unclassified_Pterapogon : Pterapogon, Iunclassified_Pterapogon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pterapogon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2896493;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pterapogon";
}
