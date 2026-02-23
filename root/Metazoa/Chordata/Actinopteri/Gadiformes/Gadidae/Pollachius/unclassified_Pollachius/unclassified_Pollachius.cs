using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Gadidae.Pollachius;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Gadidae.Pollachius.unclassified_Pollachius;

/// <summary>
/// Abstract class for unclassified Pollachius (no rank).
/// NCBI TaxId: 2625461
/// </summary>
public abstract class unclassified_Pollachius : Pollachius, Iunclassified_Pollachius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pollachius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2625461;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pollachius";
}
