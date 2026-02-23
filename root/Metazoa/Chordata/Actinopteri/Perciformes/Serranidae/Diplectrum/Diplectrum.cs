using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Serranidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Serranidae.Diplectrum;

/// <summary>
/// Abstract class for Diplectrum (genus).
/// NCBI TaxId: 184443
/// </summary>
public abstract class Diplectrum : Serranidae, IDiplectrum
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Diplectrum";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 184443;

    /// <inheritdoc />
    public virtual string GenusName => "Diplectrum";

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
