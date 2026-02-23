using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Pomacentridae.Abudefduf;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Pomacentridae.Abudefduf.unclassified_Abudefduf;

/// <summary>
/// Abstract class for unclassified Abudefduf (no rank).
/// NCBI TaxId: 2646517
/// </summary>
public abstract class unclassified_Abudefduf : Abudefduf, Iunclassified_Abudefduf
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Abudefduf";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2646517;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Abudefduf";
}
