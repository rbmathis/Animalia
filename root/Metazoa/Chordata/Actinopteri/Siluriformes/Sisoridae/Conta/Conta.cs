using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Sisoridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Sisoridae.Conta;

/// <summary>
/// Abstract class for Conta (genus).
/// NCBI TaxId: 385272
/// </summary>
public abstract class Conta : Sisoridae, IConta
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Conta";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 385272;

    /// <inheritdoc />
    public virtual string GenusName => "Conta";

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
