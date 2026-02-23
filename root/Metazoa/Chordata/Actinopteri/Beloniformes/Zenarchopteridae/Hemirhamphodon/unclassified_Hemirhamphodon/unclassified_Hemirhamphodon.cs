using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beloniformes.Zenarchopteridae.Hemirhamphodon;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beloniformes.Zenarchopteridae.Hemirhamphodon.unclassified_Hemirhamphodon;

/// <summary>
/// Abstract class for unclassified Hemirhamphodon (no rank).
/// NCBI TaxId: 2630656
/// </summary>
public abstract class unclassified_Hemirhamphodon : Hemirhamphodon, Iunclassified_Hemirhamphodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Hemirhamphodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2630656;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Hemirhamphodon";
}
