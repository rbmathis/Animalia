using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Chacidae.Chaca;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Chacidae.Chaca.unclassified_Chaca;

/// <summary>
/// Abstract class for unclassified Chaca (no rank).
/// NCBI TaxId: 2634484
/// </summary>
public abstract class unclassified_Chaca : Chaca, Iunclassified_Chaca
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Chaca";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2634484;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Chaca";
}
