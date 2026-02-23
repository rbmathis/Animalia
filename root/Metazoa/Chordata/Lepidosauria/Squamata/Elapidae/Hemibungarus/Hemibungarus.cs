using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Elapidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Elapidae.Hemibungarus;

/// <summary>
/// Abstract class for Hemibungarus (genus).
/// NCBI TaxId: 430901
/// </summary>
public abstract class Hemibungarus : Elapidae, IHemibungarus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hemibungarus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 430901;

    /// <inheritdoc />
    public virtual string GenusName => "Hemibungarus";

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
