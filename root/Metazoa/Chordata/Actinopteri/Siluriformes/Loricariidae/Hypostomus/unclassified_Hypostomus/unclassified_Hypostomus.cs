using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Hypostomus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Hypostomus.unclassified_Hypostomus;

/// <summary>
/// Abstract class for unclassified Hypostomus (no rank).
/// NCBI TaxId: 2602676
/// </summary>
public abstract class unclassified_Hypostomus : Hypostomus, Iunclassified_Hypostomus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Hypostomus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2602676;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Hypostomus";
}
