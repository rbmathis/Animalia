using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Calluella;

/// <summary>
/// Abstract class for Calluella (genus).
/// NCBI TaxId: 356264
/// </summary>
public abstract class Calluella : Microhylidae, ICalluella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Calluella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 356264;

    /// <inheritdoc />
    public virtual string GenusName => "Calluella";

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
