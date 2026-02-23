using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Procatopodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Procatopodidae.Lamprichthys;

/// <summary>
/// Abstract class for Lamprichthys (genus).
/// NCBI TaxId: 1573791
/// </summary>
public abstract class Lamprichthys : Procatopodidae, ILamprichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lamprichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1573791;

    /// <inheritdoc />
    public virtual string GenusName => "Lamprichthys";

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
