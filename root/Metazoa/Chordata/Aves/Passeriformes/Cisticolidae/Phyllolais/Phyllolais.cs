using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cisticolidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cisticolidae.Phyllolais;

/// <summary>
/// Abstract class for Phyllolais (genus).
/// NCBI TaxId: 1306890
/// </summary>
public abstract class Phyllolais : Cisticolidae, IPhyllolais
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Phyllolais";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1306890;

    /// <inheritdoc />
    public virtual string GenusName => "Phyllolais";

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
