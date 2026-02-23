using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Leptodactylidae.Adenomera;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Leptodactylidae.Adenomera.unclassified_Adenomera;

/// <summary>
/// Abstract class for unclassified Adenomera (no rank).
/// NCBI TaxId: 2621876
/// </summary>
public abstract class unclassified_Adenomera : Adenomera, Iunclassified_Adenomera
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Adenomera";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2621876;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Adenomera";
}
