using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Rivulidae.Hypsolebias;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Rivulidae.Hypsolebias.unclassified_Hypsolebias;

/// <summary>
/// Abstract class for unclassified Hypsolebias (no rank).
/// NCBI TaxId: 2677461
/// </summary>
public abstract class unclassified_Hypsolebias : Hypsolebias, Iunclassified_Hypsolebias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Hypsolebias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2677461;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Hypsolebias";
}
