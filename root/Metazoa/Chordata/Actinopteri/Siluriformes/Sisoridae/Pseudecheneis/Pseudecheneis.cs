using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Sisoridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Sisoridae.Pseudecheneis;

/// <summary>
/// Abstract class for Pseudecheneis (genus).
/// NCBI TaxId: 205341
/// </summary>
public abstract class Pseudecheneis : Sisoridae, IPseudecheneis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudecheneis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 205341;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudecheneis";

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
