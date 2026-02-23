using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Terapontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Terapontidae.Pingalla;

/// <summary>
/// Abstract class for Pingalla (genus).
/// NCBI TaxId: 1161377
/// </summary>
public abstract class Pingalla : Terapontidae, IPingalla
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pingalla";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1161377;

    /// <inheritdoc />
    public virtual string GenusName => "Pingalla";

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
