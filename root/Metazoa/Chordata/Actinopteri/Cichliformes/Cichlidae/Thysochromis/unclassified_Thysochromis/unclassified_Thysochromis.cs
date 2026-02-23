using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Thysochromis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Thysochromis.unclassified_Thysochromis;

/// <summary>
/// Abstract class for unclassified Thysochromis (no rank).
/// NCBI TaxId: 2644915
/// </summary>
public abstract class unclassified_Thysochromis : Thysochromis, Iunclassified_Thysochromis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Thysochromis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2644915;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Thysochromis";
}
