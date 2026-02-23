using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Dicrossus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Dicrossus.unclassified_Dicrossus;

/// <summary>
/// Abstract class for unclassified Dicrossus (no rank).
/// NCBI TaxId: 2685274
/// </summary>
public abstract class unclassified_Dicrossus : Dicrossus, Iunclassified_Dicrossus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Dicrossus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2685274;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Dicrossus";
}
