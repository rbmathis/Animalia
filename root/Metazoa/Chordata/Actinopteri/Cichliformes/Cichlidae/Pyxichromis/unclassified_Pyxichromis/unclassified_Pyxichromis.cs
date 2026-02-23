using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Pyxichromis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Pyxichromis.unclassified_Pyxichromis;

/// <summary>
/// Abstract class for unclassified Pyxichromis (no rank).
/// NCBI TaxId: 2766871
/// </summary>
public abstract class unclassified_Pyxichromis : Pyxichromis, Iunclassified_Pyxichromis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pyxichromis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2766871;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pyxichromis";
}
