using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae.Squalius;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae.Squalius.unclassified_Squalius;

/// <summary>
/// Abstract class for unclassified Squalius (no rank).
/// NCBI TaxId: 2642385
/// </summary>
public abstract class unclassified_Squalius : Squalius, Iunclassified_Squalius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Squalius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2642385;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Squalius";
}
