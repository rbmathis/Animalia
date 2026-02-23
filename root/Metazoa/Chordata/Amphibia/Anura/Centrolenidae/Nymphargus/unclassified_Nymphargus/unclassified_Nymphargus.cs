using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Centrolenidae.Nymphargus;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Centrolenidae.Nymphargus.unclassified_Nymphargus;

/// <summary>
/// Abstract class for unclassified Nymphargus (no rank).
/// NCBI TaxId: 2638870
/// </summary>
public abstract class unclassified_Nymphargus : Nymphargus, Iunclassified_Nymphargus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Nymphargus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2638870;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Nymphargus";
}
