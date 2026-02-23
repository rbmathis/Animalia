using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Chiasmodontidae.Chiasmodon;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Chiasmodontidae.Chiasmodon.unclassified_Chiasmodon;

/// <summary>
/// Abstract class for unclassified Chiasmodon (no rank).
/// NCBI TaxId: 2630885
/// </summary>
public abstract class unclassified_Chiasmodon : Chiasmodon, Iunclassified_Chiasmodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Chiasmodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2630885;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Chiasmodon";
}
