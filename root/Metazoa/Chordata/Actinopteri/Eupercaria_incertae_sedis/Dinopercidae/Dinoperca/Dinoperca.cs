using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Dinopercidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Dinopercidae.Dinoperca;

/// <summary>
/// Abstract class for Dinoperca (genus).
/// NCBI TaxId: 428442
/// </summary>
public abstract class Dinoperca : Dinopercidae, IDinoperca
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dinoperca";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 428442;

    /// <inheritdoc />
    public virtual string GenusName => "Dinoperca";

    /// <inheritdoc />
    public virtual string[] GenusCharacteristics => new[]
    {
        "Large body size",
        "Social pack structure",
        "Complex hunting strategies",
        "Highly developed olfaction",
        "Territorial behavior"
    };

    /// <inheritdoc />
    public virtual bool CanInterbreed => true;

}
