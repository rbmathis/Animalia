using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Poeciliidae.Gambusia;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Poeciliidae.Gambusia.unclassified_Gambusia;

/// <summary>
/// Abstract class for unclassified Gambusia (no rank).
/// NCBI TaxId: 2634307
/// </summary>
public abstract class unclassified_Gambusia : Gambusia, Iunclassified_Gambusia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Gambusia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2634307;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Gambusia";
}
