using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Contopus;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Contopus.unclassified_Contopus;

/// <summary>
/// Abstract class for unclassified Contopus (no rank).
/// NCBI TaxId: 3112945
/// </summary>
public abstract class unclassified_Contopus : Contopus, Iunclassified_Contopus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Contopus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3112945;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Contopus";
}
