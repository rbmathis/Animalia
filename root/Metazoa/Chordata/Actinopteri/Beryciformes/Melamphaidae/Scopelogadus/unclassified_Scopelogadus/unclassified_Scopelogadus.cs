using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beryciformes.Melamphaidae.Scopelogadus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beryciformes.Melamphaidae.Scopelogadus.unclassified_Scopelogadus;

/// <summary>
/// Abstract class for unclassified Scopelogadus (no rank).
/// NCBI TaxId: 2620788
/// </summary>
public abstract class unclassified_Scopelogadus : Scopelogadus, Iunclassified_Scopelogadus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Scopelogadus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2620788;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Scopelogadus";
}
