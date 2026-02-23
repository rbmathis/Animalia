using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Sargochromis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Sargochromis.unclassified_Sargochromis;

/// <summary>
/// Abstract class for unclassified Sargochromis (no rank).
/// NCBI TaxId: 2647222
/// </summary>
public abstract class unclassified_Sargochromis : Sargochromis, Iunclassified_Sargochromis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Sargochromis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2647222;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Sargochromis";
}
