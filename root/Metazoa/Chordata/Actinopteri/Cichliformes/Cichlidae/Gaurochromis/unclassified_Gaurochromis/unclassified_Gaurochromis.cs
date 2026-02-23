using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Gaurochromis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Gaurochromis.unclassified_Gaurochromis;

/// <summary>
/// Abstract class for unclassified Gaurochromis (no rank).
/// NCBI TaxId: 2685607
/// </summary>
public abstract class unclassified_Gaurochromis : Gaurochromis, Iunclassified_Gaurochromis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Gaurochromis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2685607;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Gaurochromis";
}
