using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Chaetodontiformes.Leiognathidae.Equulites;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Chaetodontiformes.Leiognathidae.Equulites.unclassified_Equulites;

/// <summary>
/// Abstract class for unclassified Equulites (no rank).
/// NCBI TaxId: 2609512
/// </summary>
public abstract class unclassified_Equulites : Equulites, Iunclassified_Equulites
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Equulites";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2609512;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Equulites";
}
