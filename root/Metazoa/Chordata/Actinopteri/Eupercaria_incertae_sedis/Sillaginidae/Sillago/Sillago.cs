using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sillaginidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sillaginidae.Sillago;

/// <summary>
/// Abstract class for Sillago (genus).
/// NCBI TaxId: 43257
/// </summary>
public abstract class Sillago : Sillaginidae, ISillago
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sillago";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 43257;

    /// <inheritdoc />
    public virtual string GenusName => "Sillago";

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
