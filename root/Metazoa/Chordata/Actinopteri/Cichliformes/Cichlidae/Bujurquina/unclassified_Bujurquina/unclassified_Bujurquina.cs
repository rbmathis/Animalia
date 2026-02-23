using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Bujurquina;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Bujurquina.unclassified_Bujurquina;

/// <summary>
/// Abstract class for unclassified Bujurquina (no rank).
/// NCBI TaxId: 2627438
/// </summary>
public abstract class unclassified_Bujurquina : Bujurquina, Iunclassified_Bujurquina
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Bujurquina";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2627438;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Bujurquina";
}
