using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Telmatochromis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Telmatochromis.unclassified_Telmatochromis;

/// <summary>
/// Abstract class for unclassified Telmatochromis (no rank).
/// NCBI TaxId: 2622245
/// </summary>
public abstract class unclassified_Telmatochromis : Telmatochromis, Iunclassified_Telmatochromis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Telmatochromis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2622245;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Telmatochromis";
}
