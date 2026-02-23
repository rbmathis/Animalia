using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Lamprologus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Lamprologus.unclassified_Lamprologus;

/// <summary>
/// Abstract class for unclassified Lamprologus (no rank).
/// NCBI TaxId: 2642414
/// </summary>
public abstract class unclassified_Lamprologus : Lamprologus, Iunclassified_Lamprologus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Lamprologus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2642414;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Lamprologus";
}
