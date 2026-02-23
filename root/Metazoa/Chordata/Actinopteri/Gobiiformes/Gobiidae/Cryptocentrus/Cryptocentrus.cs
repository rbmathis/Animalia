using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Cryptocentrus;

/// <summary>
/// Abstract class for Cryptocentrus (genus).
/// NCBI TaxId: 94313
/// </summary>
public abstract class Cryptocentrus : Gobiidae, ICryptocentrus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cryptocentrus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 94313;

    /// <inheritdoc />
    public virtual string GenusName => "Cryptocentrus";

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
