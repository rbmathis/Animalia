using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Chalinochromis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Chalinochromis.unclassified_Chalinochromis;

/// <summary>
/// Abstract class for unclassified Chalinochromis (no rank).
/// NCBI TaxId: 2622340
/// </summary>
public abstract class unclassified_Chalinochromis : Chalinochromis, Iunclassified_Chalinochromis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Chalinochromis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2622340;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Chalinochromis";
}
