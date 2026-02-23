using AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Agapornis;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Agapornis.unclassified_Agapornis;

/// <summary>
/// Abstract class for unclassified Agapornis (no rank).
/// NCBI TaxId: 2643795
/// </summary>
public abstract class unclassified_Agapornis : Agapornis, Iunclassified_Agapornis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Agapornis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2643795;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Agapornis";
}
