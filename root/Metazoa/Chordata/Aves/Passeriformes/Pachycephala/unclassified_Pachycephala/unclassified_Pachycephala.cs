using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pachycephala;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pachycephala.unclassified_Pachycephala;

/// <summary>
/// Abstract class for unclassified Pachycephala (no rank).
/// NCBI TaxId: 2629920
/// </summary>
public abstract class unclassified_Pachycephala : Pachycephala, Iunclassified_Pachycephala
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pachycephala";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2629920;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pachycephala";
}
