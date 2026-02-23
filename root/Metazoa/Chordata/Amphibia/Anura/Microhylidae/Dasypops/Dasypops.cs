using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Dasypops;

/// <summary>
/// Abstract class for Dasypops (genus).
/// NCBI TaxId: 356341
/// </summary>
public abstract class Dasypops : Microhylidae, IDasypops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dasypops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 356341;

    /// <inheritdoc />
    public virtual string GenusName => "Dasypops";

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
