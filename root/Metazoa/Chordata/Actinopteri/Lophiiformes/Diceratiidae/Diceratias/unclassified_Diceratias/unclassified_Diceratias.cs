using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Diceratiidae.Diceratias;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Diceratiidae.Diceratias.unclassified_Diceratias;

/// <summary>
/// Abstract class for unclassified Diceratias (no rank).
/// NCBI TaxId: 2893521
/// </summary>
public abstract class unclassified_Diceratias : Diceratias, Iunclassified_Diceratias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Diceratias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2893521;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Diceratias";
}
