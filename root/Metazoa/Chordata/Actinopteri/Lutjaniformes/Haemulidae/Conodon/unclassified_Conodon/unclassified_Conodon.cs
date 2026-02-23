using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lutjaniformes.Haemulidae.Conodon;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lutjaniformes.Haemulidae.Conodon.unclassified_Conodon;

/// <summary>
/// Abstract class for unclassified Conodon (no rank).
/// NCBI TaxId: 2648110
/// </summary>
public abstract class unclassified_Conodon : Conodon, Iunclassified_Conodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Conodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2648110;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Conodon";
}
