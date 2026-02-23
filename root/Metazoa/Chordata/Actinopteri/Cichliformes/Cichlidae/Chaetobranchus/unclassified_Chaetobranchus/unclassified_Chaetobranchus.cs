using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Chaetobranchus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Chaetobranchus.unclassified_Chaetobranchus;

/// <summary>
/// Abstract class for unclassified Chaetobranchus (no rank).
/// NCBI TaxId: 3101824
/// </summary>
public abstract class unclassified_Chaetobranchus : Chaetobranchus, Iunclassified_Chaetobranchus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Chaetobranchus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3101824;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Chaetobranchus";
}
