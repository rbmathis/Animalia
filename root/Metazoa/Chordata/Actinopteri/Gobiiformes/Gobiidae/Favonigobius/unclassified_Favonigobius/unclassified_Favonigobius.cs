using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Favonigobius;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Favonigobius.unclassified_Favonigobius;

/// <summary>
/// Abstract class for unclassified Favonigobius (no rank).
/// NCBI TaxId: 2647151
/// </summary>
public abstract class unclassified_Favonigobius : Favonigobius, Iunclassified_Favonigobius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Favonigobius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2647151;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Favonigobius";
}
