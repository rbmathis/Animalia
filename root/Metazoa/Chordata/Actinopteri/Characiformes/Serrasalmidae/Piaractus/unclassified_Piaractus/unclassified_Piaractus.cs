using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Serrasalmidae.Piaractus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Serrasalmidae.Piaractus.unclassified_Piaractus;

/// <summary>
/// Abstract class for unclassified Piaractus (no rank).
/// NCBI TaxId: 2634820
/// </summary>
public abstract class unclassified_Piaractus : Piaractus, Iunclassified_Piaractus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Piaractus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2634820;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Piaractus";
}
