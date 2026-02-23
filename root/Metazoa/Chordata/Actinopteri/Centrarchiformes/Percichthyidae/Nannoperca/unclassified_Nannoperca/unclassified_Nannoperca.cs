using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Percichthyidae.Nannoperca;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Percichthyidae.Nannoperca.unclassified_Nannoperca;

/// <summary>
/// Abstract class for unclassified Nannoperca (no rank).
/// NCBI TaxId: 2643624
/// </summary>
public abstract class unclassified_Nannoperca : Nannoperca, Iunclassified_Nannoperca
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Nannoperca";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2643624;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Nannoperca";
}
