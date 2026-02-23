using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Siluridae.Ompok;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Siluridae.Ompok.unclassified_Ompok;

/// <summary>
/// Abstract class for unclassified Ompok (no rank).
/// NCBI TaxId: 2639903
/// </summary>
public abstract class unclassified_Ompok : Ompok, Iunclassified_Ompok
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Ompok";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2639903;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Ompok";
}
