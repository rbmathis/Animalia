using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.unclassified_Pseudocrenilabrinae;

/// <summary>
/// Abstract class for unclassified Pseudocrenilabrinae (no rank).
/// NCBI TaxId: 2048940
/// </summary>
public abstract class unclassified_Pseudocrenilabrinae : Cichlidae, Iunclassified_Pseudocrenilabrinae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pseudocrenilabrinae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2048940;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pseudocrenilabrinae";
}
