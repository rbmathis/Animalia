using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Bregmacerotidae.Bregmaceros;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Bregmacerotidae.Bregmaceros.unclassified_Bregmaceros;

/// <summary>
/// Abstract class for unclassified Bregmaceros (no rank).
/// NCBI TaxId: 2646471
/// </summary>
public abstract class unclassified_Bregmaceros : Bregmaceros, Iunclassified_Bregmaceros
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Bregmaceros";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2646471;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Bregmaceros";
}
