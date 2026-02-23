using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Limnodynastidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Limnodynastidae.Platyplectrum;

/// <summary>
/// Abstract class for Platyplectrum (genus).
/// NCBI TaxId: 2741727
/// </summary>
public abstract class Platyplectrum : Limnodynastidae, IPlatyplectrum
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Platyplectrum";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2741727;

    /// <inheritdoc />
    public virtual string GenusName => "Platyplectrum";

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
