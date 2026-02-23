using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gerreiformes.Gerreidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gerreiformes.Gerreidae.unclassified_Gerreidae;

/// <summary>
/// Abstract class for unclassified Gerreidae (no rank).
/// NCBI TaxId: 1182070
/// </summary>
public abstract class unclassified_Gerreidae : Gerreidae, Iunclassified_Gerreidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Gerreidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1182070;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Gerreidae";
}
