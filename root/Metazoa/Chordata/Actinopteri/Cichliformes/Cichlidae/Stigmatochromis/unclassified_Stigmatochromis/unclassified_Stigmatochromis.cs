using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Stigmatochromis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Stigmatochromis.unclassified_Stigmatochromis;

/// <summary>
/// Abstract class for unclassified Stigmatochromis (no rank).
/// NCBI TaxId: 2633819
/// </summary>
public abstract class unclassified_Stigmatochromis : Stigmatochromis, Iunclassified_Stigmatochromis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Stigmatochromis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2633819;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Stigmatochromis";
}
