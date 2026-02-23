using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Sisoridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Sisoridae.Bagarius;

/// <summary>
/// Abstract class for Bagarius (genus).
/// NCBI TaxId: 175773
/// </summary>
public abstract class Bagarius : Sisoridae, IBagarius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bagarius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 175773;

    /// <inheritdoc />
    public virtual string GenusName => "Bagarius";

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
