using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Oxyurichthys;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Oxyurichthys.unclassified_Oxyurichthys;

/// <summary>
/// Abstract class for unclassified Oxyurichthys (no rank).
/// NCBI TaxId: 2635376
/// </summary>
public abstract class unclassified_Oxyurichthys : Oxyurichthys, Iunclassified_Oxyurichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Oxyurichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2635376;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Oxyurichthys";
}
