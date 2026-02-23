using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Gobionidae.Platysmacheilus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Gobionidae.Platysmacheilus.unclassified_Platysmacheilus;

/// <summary>
/// Abstract class for unclassified Platysmacheilus (no rank).
/// NCBI TaxId: 2622371
/// </summary>
public abstract class unclassified_Platysmacheilus : Platysmacheilus, Iunclassified_Platysmacheilus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Platysmacheilus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2622371;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Platysmacheilus";
}
