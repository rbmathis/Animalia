using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Caristiidae.Caristius;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Caristiidae.Caristius.unclassified_Caristius;

/// <summary>
/// Abstract class for unclassified Caristius (no rank).
/// NCBI TaxId: 2685419
/// </summary>
public abstract class unclassified_Caristius : Caristius, Iunclassified_Caristius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Caristius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2685419;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Caristius";
}
