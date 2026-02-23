using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Semiplotus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Semiplotus.unclassified_Semiplotus;

/// <summary>
/// Abstract class for unclassified Semiplotus (no rank).
/// NCBI TaxId: 2623983
/// </summary>
public abstract class unclassified_Semiplotus : Semiplotus, Iunclassified_Semiplotus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Semiplotus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2623983;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Semiplotus";
}
