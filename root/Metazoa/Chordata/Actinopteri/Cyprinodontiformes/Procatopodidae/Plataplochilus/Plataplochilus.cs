using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Procatopodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Procatopodidae.Plataplochilus;

/// <summary>
/// Abstract class for Plataplochilus (genus).
/// NCBI TaxId: 446501
/// </summary>
public abstract class Plataplochilus : Procatopodidae, IPlataplochilus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Plataplochilus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 446501;

    /// <inheritdoc />
    public virtual string GenusName => "Plataplochilus";

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
