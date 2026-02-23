using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acanthuriformes.Acanthuridae.Acanthurus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acanthuriformes.Acanthuridae.Acanthurus.unclassified_Acanthurus;

/// <summary>
/// Abstract class for unclassified Acanthurus (no rank).
/// NCBI TaxId: 2634894
/// </summary>
public abstract class unclassified_Acanthurus : Acanthurus, Iunclassified_Acanthurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Acanthurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2634894;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Acanthurus";
}
