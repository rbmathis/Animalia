using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Aequidens;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Aequidens.unclassified_Aequidens;

/// <summary>
/// Abstract class for unclassified Aequidens (no rank).
/// NCBI TaxId: 2627132
/// </summary>
public abstract class unclassified_Aequidens : Aequidens, Iunclassified_Aequidens
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Aequidens";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2627132;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Aequidens";
}
