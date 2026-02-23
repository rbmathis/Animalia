using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Akysidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Akysidae.Akysis;

/// <summary>
/// Abstract class for Akysis (genus).
/// NCBI TaxId: 205335
/// </summary>
public abstract class Akysis : Akysidae, IAkysis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Akysis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 205335;

    /// <inheritdoc />
    public virtual string GenusName => "Akysis";

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
