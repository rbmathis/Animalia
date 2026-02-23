using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Embiotocidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Embiotocidae.Micrometrus;

/// <summary>
/// Abstract class for Micrometrus (genus).
/// NCBI TaxId: 50813
/// </summary>
public abstract class Micrometrus : Embiotocidae, IMicrometrus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Micrometrus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 50813;

    /// <inheritdoc />
    public virtual string GenusName => "Micrometrus";

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
