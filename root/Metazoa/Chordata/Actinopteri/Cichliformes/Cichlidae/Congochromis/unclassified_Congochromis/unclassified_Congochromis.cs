using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Congochromis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Congochromis.unclassified_Congochromis;

/// <summary>
/// Abstract class for unclassified Congochromis (no rank).
/// NCBI TaxId: 2632640
/// </summary>
public abstract class unclassified_Congochromis : Congochromis, Iunclassified_Congochromis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Congochromis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2632640;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Congochromis";
}
