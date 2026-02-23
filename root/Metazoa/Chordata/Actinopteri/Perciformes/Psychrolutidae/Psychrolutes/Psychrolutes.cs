using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Psychrolutidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Psychrolutidae.Psychrolutes;

/// <summary>
/// Abstract class for Psychrolutes (genus).
/// NCBI TaxId: 320384
/// </summary>
public abstract class Psychrolutes : Psychrolutidae, IPsychrolutes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Psychrolutes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 320384;

    /// <inheritdoc />
    public virtual string GenusName => "Psychrolutes";

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
