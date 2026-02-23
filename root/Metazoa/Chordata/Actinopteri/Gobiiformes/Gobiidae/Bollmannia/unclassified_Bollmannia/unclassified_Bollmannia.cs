using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Bollmannia;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Bollmannia.unclassified_Bollmannia;

/// <summary>
/// Abstract class for unclassified Bollmannia (no rank).
/// NCBI TaxId: 2633703
/// </summary>
public abstract class unclassified_Bollmannia : Bollmannia, Iunclassified_Bollmannia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Bollmannia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2633703;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Bollmannia";
}
