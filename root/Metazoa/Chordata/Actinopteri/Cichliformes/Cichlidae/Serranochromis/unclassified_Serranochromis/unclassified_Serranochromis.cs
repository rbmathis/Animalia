using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Serranochromis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Serranochromis.unclassified_Serranochromis;

/// <summary>
/// Abstract class for unclassified Serranochromis (no rank).
/// NCBI TaxId: 2630804
/// </summary>
public abstract class unclassified_Serranochromis : Serranochromis, Iunclassified_Serranochromis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Serranochromis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2630804;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Serranochromis";
}
