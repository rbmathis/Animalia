using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anabantiformes.Badidae.Badis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anabantiformes.Badidae.Badis.unclassified_Badis;

/// <summary>
/// Abstract class for unclassified Badis (no rank).
/// NCBI TaxId: 2619079
/// </summary>
public abstract class unclassified_Badis : Badis, Iunclassified_Badis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Badis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2619079;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Badis";
}
