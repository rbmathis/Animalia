using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Istigobius;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Istigobius.unclassified_Istigobius;

/// <summary>
/// Abstract class for unclassified Istigobius (no rank).
/// NCBI TaxId: 2664830
/// </summary>
public abstract class unclassified_Istigobius : Istigobius, Iunclassified_Istigobius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Istigobius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2664830;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Istigobius";
}
