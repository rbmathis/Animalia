using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Sisoridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Sisoridae.Erethistes;

/// <summary>
/// Abstract class for Erethistes (genus).
/// NCBI TaxId: 337784
/// </summary>
public abstract class Erethistes : Sisoridae, IErethistes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Erethistes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 337784;

    /// <inheritdoc />
    public virtual string GenusName => "Erethistes";

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
