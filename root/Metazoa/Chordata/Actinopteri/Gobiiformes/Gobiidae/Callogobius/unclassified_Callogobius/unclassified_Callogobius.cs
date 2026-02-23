using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Callogobius;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Callogobius.unclassified_Callogobius;

/// <summary>
/// Abstract class for unclassified Callogobius (no rank).
/// NCBI TaxId: 2646110
/// </summary>
public abstract class unclassified_Callogobius : Callogobius, Iunclassified_Callogobius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Callogobius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2646110;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Callogobius";
}
