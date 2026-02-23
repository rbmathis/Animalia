using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Rivulidae.Cynolebias;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Rivulidae.Cynolebias.unclassified_Cynolebias;

/// <summary>
/// Abstract class for unclassified Cynolebias (no rank).
/// NCBI TaxId: 2627636
/// </summary>
public abstract class unclassified_Cynolebias : Cynolebias, Iunclassified_Cynolebias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Cynolebias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2627636;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Cynolebias";
}
