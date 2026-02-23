using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Erinaceidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Erinaceidae.Podogymnura;

/// <summary>
/// Abstract class for Podogymnura (genus).
/// NCBI TaxId: 48904
/// </summary>
public abstract class Podogymnura : Erinaceidae, IPodogymnura
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Podogymnura";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 48904;

    /// <inheritdoc />
    public virtual string GenusName => "Podogymnura";

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
