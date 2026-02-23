using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Mugilogobius;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Mugilogobius.unclassified_Mugilogobius;

/// <summary>
/// Abstract class for unclassified Mugilogobius (no rank).
/// NCBI TaxId: 2625058
/// </summary>
public abstract class unclassified_Mugilogobius : Mugilogobius, Iunclassified_Mugilogobius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Mugilogobius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2625058;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Mugilogobius";
}
