using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Procyonidae.Nasua;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Procyonidae.Nasua.unclassified_Nasua;

/// <summary>
/// Abstract class for unclassified Nasua (no rank).
/// NCBI TaxId: 2649482
/// </summary>
public abstract class unclassified_Nasua : Nasua, Iunclassified_Nasua
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Nasua";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2649482;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Nasua";
}
