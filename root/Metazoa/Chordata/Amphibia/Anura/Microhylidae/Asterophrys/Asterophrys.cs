using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Asterophrys;

/// <summary>
/// Abstract class for Asterophrys (genus).
/// NCBI TaxId: 445147
/// </summary>
public abstract class Asterophrys : Microhylidae, IAsterophrys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Asterophrys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 445147;

    /// <inheritdoc />
    public virtual string GenusName => "Asterophrys";

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
