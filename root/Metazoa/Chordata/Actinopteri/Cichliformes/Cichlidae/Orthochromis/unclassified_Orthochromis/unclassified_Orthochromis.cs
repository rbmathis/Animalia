using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Orthochromis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Orthochromis.unclassified_Orthochromis;

/// <summary>
/// Abstract class for unclassified Orthochromis (no rank).
/// NCBI TaxId: 2645636
/// </summary>
public abstract class unclassified_Orthochromis : Orthochromis, Iunclassified_Orthochromis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Orthochromis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2645636;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Orthochromis";
}
