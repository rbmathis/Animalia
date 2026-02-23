using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Rivulidae.Austrolebias;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Rivulidae.Austrolebias.unclassified_Austrolebias;

/// <summary>
/// Abstract class for unclassified Austrolebias (no rank).
/// NCBI TaxId: 2629408
/// </summary>
public abstract class unclassified_Austrolebias : Austrolebias, Iunclassified_Austrolebias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Austrolebias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2629408;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Austrolebias";
}
