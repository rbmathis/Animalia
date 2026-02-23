using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Procatopodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Procatopodidae.Procatopus;

/// <summary>
/// Abstract class for Procatopus (genus).
/// NCBI TaxId: 691894
/// </summary>
public abstract class Procatopus : Procatopodidae, IProcatopus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Procatopus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 691894;

    /// <inheritdoc />
    public virtual string GenusName => "Procatopus";

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
