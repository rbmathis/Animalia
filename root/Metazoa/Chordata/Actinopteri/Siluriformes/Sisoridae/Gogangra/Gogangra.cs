using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Sisoridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Sisoridae.Gogangra;

/// <summary>
/// Abstract class for Gogangra (genus).
/// NCBI TaxId: 385295
/// </summary>
public abstract class Gogangra : Sisoridae, IGogangra
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gogangra";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 385295;

    /// <inheritdoc />
    public virtual string GenusName => "Gogangra";

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
