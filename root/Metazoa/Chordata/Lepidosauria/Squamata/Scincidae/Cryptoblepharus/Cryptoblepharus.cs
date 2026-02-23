using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Cryptoblepharus;

/// <summary>
/// Abstract class for Cryptoblepharus (genus).
/// NCBI TaxId: 161939
/// </summary>
public abstract class Cryptoblepharus : Scincidae, ICryptoblepharus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cryptoblepharus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 161939;

    /// <inheritdoc />
    public virtual string GenusName => "Cryptoblepharus";

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
