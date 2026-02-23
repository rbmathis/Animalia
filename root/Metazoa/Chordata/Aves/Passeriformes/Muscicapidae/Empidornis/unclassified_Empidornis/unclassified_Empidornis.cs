using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Muscicapidae.Empidornis;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Muscicapidae.Empidornis.unclassified_Empidornis;

/// <summary>
/// Abstract class for unclassified Empidornis (no rank).
/// NCBI TaxId: 2621969
/// </summary>
public abstract class unclassified_Empidornis : Empidornis, Iunclassified_Empidornis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Empidornis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2621969;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Empidornis";
}
