using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Bagridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Bagridae.Olyra;

/// <summary>
/// Abstract class for Olyra (genus).
/// NCBI TaxId: 210595
/// </summary>
public abstract class Olyra : Bagridae, IOlyra
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Olyra";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 210595;

    /// <inheritdoc />
    public virtual string GenusName => "Olyra";

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
