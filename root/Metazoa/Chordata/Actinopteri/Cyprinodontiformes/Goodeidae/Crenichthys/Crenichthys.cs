using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Goodeidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Goodeidae.Crenichthys;

/// <summary>
/// Abstract class for Crenichthys (genus).
/// NCBI TaxId: 28759
/// </summary>
public abstract class Crenichthys : Goodeidae, ICrenichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Crenichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 28759;

    /// <inheritdoc />
    public virtual string GenusName => "Crenichthys";

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
