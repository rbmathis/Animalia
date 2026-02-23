using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Chaetodontiformes.Leiognathidae.Photopectoralis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Chaetodontiformes.Leiognathidae.Photopectoralis.unclassified_Photopectoralis;

/// <summary>
/// Abstract class for unclassified Photopectoralis (no rank).
/// NCBI TaxId: 2619188
/// </summary>
public abstract class unclassified_Photopectoralis : Photopectoralis, Iunclassified_Photopectoralis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Photopectoralis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2619188;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Photopectoralis";
}
