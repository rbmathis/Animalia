using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Soricidae.Paracrocidura;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Soricidae.Paracrocidura.unclassified_Paracrocidura;

/// <summary>
/// Abstract class for unclassified Paracrocidura (no rank).
/// NCBI TaxId: 2661592
/// </summary>
public abstract class unclassified_Paracrocidura : Paracrocidura, Iunclassified_Paracrocidura
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Paracrocidura";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2661592;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Paracrocidura";
}
