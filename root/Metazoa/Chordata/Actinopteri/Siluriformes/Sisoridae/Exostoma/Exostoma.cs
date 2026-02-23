using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Sisoridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Sisoridae.Exostoma;

/// <summary>
/// Abstract class for Exostoma (genus).
/// NCBI TaxId: 205337
/// </summary>
public abstract class Exostoma : Sisoridae, IExostoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Exostoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 205337;

    /// <inheritdoc />
    public virtual string GenusName => "Exostoma";

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
