using AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Bucconidae.Nystalus;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Bucconidae.Nystalus.unclassified_Nystalus;

/// <summary>
/// Abstract class for unclassified Nystalus (no rank).
/// NCBI TaxId: 2647721
/// </summary>
public abstract class unclassified_Nystalus : Nystalus, Iunclassified_Nystalus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Nystalus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2647721;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Nystalus";
}
