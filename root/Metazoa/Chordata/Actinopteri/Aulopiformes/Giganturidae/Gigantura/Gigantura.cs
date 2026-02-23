using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Giganturidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Giganturidae.Gigantura;

/// <summary>
/// Abstract class for Gigantura (genus).
/// NCBI TaxId: 172115
/// </summary>
public abstract class Gigantura : Giganturidae, IGigantura
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gigantura";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 172115;

    /// <inheritdoc />
    public virtual string GenusName => "Gigantura";

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
