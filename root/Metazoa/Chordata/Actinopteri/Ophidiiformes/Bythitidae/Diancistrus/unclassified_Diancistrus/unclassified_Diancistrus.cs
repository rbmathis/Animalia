using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Bythitidae.Diancistrus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Bythitidae.Diancistrus.unclassified_Diancistrus;

/// <summary>
/// Abstract class for unclassified Diancistrus (no rank).
/// NCBI TaxId: 2622096
/// </summary>
public abstract class unclassified_Diancistrus : Diancistrus, Iunclassified_Diancistrus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Diancistrus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2622096;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Diancistrus";
}
