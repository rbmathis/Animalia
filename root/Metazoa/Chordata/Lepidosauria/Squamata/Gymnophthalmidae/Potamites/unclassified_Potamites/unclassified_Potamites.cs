using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae.Potamites;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae.Potamites.unclassified_Potamites;

/// <summary>
/// Abstract class for unclassified Potamites (no rank).
/// NCBI TaxId: 2927908
/// </summary>
public abstract class unclassified_Potamites : Potamites, Iunclassified_Potamites
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Potamites";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2927908;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Potamites";
}
