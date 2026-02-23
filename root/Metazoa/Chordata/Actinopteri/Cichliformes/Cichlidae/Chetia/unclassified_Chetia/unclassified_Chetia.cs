using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Chetia;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Chetia.unclassified_Chetia;

/// <summary>
/// Abstract class for unclassified Chetia (no rank).
/// NCBI TaxId: 2625025
/// </summary>
public abstract class unclassified_Chetia : Chetia, Iunclassified_Chetia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Chetia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2625025;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Chetia";
}
