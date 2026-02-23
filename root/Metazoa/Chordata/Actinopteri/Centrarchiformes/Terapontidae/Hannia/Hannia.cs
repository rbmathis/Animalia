using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Terapontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Terapontidae.Hannia;

/// <summary>
/// Abstract class for Hannia (genus).
/// NCBI TaxId: 1161370
/// </summary>
public abstract class Hannia : Terapontidae, IHannia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hannia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1161370;

    /// <inheritdoc />
    public virtual string GenusName => "Hannia";

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
