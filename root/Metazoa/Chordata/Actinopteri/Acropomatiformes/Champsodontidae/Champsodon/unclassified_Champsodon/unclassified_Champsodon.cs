using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Champsodontidae.Champsodon;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Champsodontidae.Champsodon.unclassified_Champsodon;

/// <summary>
/// Abstract class for unclassified Champsodon (no rank).
/// NCBI TaxId: 2685283
/// </summary>
public abstract class unclassified_Champsodon : Champsodon, Iunclassified_Champsodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Champsodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2685283;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Champsodon";
}
