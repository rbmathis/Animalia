using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Serrasalmidae.Myloplus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Serrasalmidae.Myloplus.unclassified_Myloplus;

/// <summary>
/// Abstract class for unclassified Myloplus (no rank).
/// NCBI TaxId: 2685409
/// </summary>
public abstract class unclassified_Myloplus : Myloplus, Iunclassified_Myloplus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Myloplus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2685409;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Myloplus";
}
