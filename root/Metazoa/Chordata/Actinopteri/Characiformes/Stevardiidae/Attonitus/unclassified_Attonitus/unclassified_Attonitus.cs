using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Stevardiidae.Attonitus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Stevardiidae.Attonitus.unclassified_Attonitus;

/// <summary>
/// Abstract class for unclassified Attonitus (no rank).
/// NCBI TaxId: 3451279
/// </summary>
public abstract class unclassified_Attonitus : Attonitus, Iunclassified_Attonitus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Attonitus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3451279;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Attonitus";
}
