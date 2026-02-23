using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Cyphotilapia;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Cyphotilapia.unclassified_Cyphotilapia;

/// <summary>
/// Abstract class for unclassified Cyphotilapia (no rank).
/// NCBI TaxId: 2631766
/// </summary>
public abstract class unclassified_Cyphotilapia : Cyphotilapia, Iunclassified_Cyphotilapia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Cyphotilapia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2631766;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Cyphotilapia";
}
