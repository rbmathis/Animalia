using AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Gypopsitta;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Gypopsitta.unclassified_Gypopsitta;

/// <summary>
/// Abstract class for unclassified Gypopsitta (no rank).
/// NCBI TaxId: 3243340
/// </summary>
public abstract class unclassified_Gypopsitta : Gypopsitta, Iunclassified_Gypopsitta
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Gypopsitta";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3243340;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Gypopsitta";
}
