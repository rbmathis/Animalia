using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Bagridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Bagridae.Batasio;

/// <summary>
/// Abstract class for Batasio (genus).
/// NCBI TaxId: 337693
/// </summary>
public abstract class Batasio : Bagridae, IBatasio
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Batasio";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 337693;

    /// <inheritdoc />
    public virtual string GenusName => "Batasio";

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
