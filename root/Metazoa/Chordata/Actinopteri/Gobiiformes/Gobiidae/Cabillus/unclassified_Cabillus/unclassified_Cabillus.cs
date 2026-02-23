using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Cabillus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Cabillus.unclassified_Cabillus;

/// <summary>
/// Abstract class for unclassified Cabillus (no rank).
/// NCBI TaxId: 2618507
/// </summary>
public abstract class unclassified_Cabillus : Cabillus, Iunclassified_Cabillus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Cabillus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2618507;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Cabillus";
}
