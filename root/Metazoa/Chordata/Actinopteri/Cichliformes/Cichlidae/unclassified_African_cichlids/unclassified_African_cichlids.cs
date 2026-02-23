using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.unclassified_African_cichlids;

/// <summary>
/// Abstract class for unclassified African cichlids (no rank).
/// NCBI TaxId: 411915
/// </summary>
public abstract class unclassified_African_cichlids : Cichlidae, Iunclassified_African_cichlids
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified African cichlids";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 411915;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_African_cichlids";
}
