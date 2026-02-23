using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characidae.Odontostilbe;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characidae.Odontostilbe.unclassified_Odontostilbe;

/// <summary>
/// Abstract class for unclassified Odontostilbe (no rank).
/// NCBI TaxId: 2632291
/// </summary>
public abstract class unclassified_Odontostilbe : Odontostilbe, Iunclassified_Odontostilbe
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Odontostilbe";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2632291;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Odontostilbe";
}
