using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Viverridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Viverridae.Macrogalidia;

/// <summary>
/// Abstract class for Macrogalidia (genus).
/// NCBI TaxId: 1198223
/// </summary>
public abstract class Macrogalidia : Viverridae, IMacrogalidia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Macrogalidia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1198223;

    /// <inheritdoc />
    public virtual string GenusName => "Macrogalidia";

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
