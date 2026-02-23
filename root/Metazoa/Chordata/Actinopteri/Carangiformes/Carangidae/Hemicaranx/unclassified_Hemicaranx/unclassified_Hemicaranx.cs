using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangiformes.Carangidae.Hemicaranx;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangiformes.Carangidae.Hemicaranx.unclassified_Hemicaranx;

/// <summary>
/// Abstract class for unclassified Hemicaranx (no rank).
/// NCBI TaxId: 3049920
/// </summary>
public abstract class unclassified_Hemicaranx : Hemicaranx, Iunclassified_Hemicaranx
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Hemicaranx";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3049920;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Hemicaranx";
}
