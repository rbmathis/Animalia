using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Galagidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Galagidae.Otolemur;

/// <summary>
/// Abstract class for Otolemur (genus).
/// NCBI TaxId: 30610
/// </summary>
public abstract class Otolemur : Galagidae, IOtolemur
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Otolemur";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 30610;

    /// <inheritdoc />
    public virtual string GenusName => "Otolemur";

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
