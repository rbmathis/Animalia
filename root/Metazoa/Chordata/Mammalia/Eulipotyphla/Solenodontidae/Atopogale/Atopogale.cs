using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Solenodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Solenodontidae.Atopogale;

/// <summary>
/// Abstract class for Atopogale (genus).
/// NCBI TaxId: 3370990
/// </summary>
public abstract class Atopogale : Solenodontidae, IAtopogale
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Atopogale";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3370990;

    /// <inheritdoc />
    public virtual string GenusName => "Atopogale";

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
