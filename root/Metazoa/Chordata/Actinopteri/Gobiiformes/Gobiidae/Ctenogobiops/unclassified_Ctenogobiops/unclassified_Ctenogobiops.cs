using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Ctenogobiops;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Ctenogobiops.unclassified_Ctenogobiops;

/// <summary>
/// Abstract class for unclassified Ctenogobiops (no rank).
/// NCBI TaxId: 2623392
/// </summary>
public abstract class unclassified_Ctenogobiops : Ctenogobiops, Iunclassified_Ctenogobiops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Ctenogobiops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2623392;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Ctenogobiops";
}
