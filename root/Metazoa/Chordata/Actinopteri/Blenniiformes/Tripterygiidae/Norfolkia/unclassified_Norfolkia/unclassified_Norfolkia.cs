using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Tripterygiidae.Norfolkia;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Tripterygiidae.Norfolkia.unclassified_Norfolkia;

/// <summary>
/// Abstract class for unclassified Norfolkia (no rank).
/// NCBI TaxId: 3444685
/// </summary>
public abstract class unclassified_Norfolkia : Norfolkia, Iunclassified_Norfolkia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Norfolkia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3444685;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Norfolkia";
}
