using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Cyathopharynx;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Cyathopharynx.unclassified_Cyathopharynx;

/// <summary>
/// Abstract class for unclassified Cyathopharynx (no rank).
/// NCBI TaxId: 2643120
/// </summary>
public abstract class unclassified_Cyathopharynx : Cyathopharynx, Iunclassified_Cyathopharynx
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Cyathopharynx";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2643120;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Cyathopharynx";
}
