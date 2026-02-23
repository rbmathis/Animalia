using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Dinopercidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Dinopercidae.Centrarchops;

/// <summary>
/// Abstract class for Centrarchops (genus).
/// NCBI TaxId: 428440
/// </summary>
public abstract class Centrarchops : Dinopercidae, ICentrarchops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Centrarchops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 428440;

    /// <inheritdoc />
    public virtual string GenusName => "Centrarchops";

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
