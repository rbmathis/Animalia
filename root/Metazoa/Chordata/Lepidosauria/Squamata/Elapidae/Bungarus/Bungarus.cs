using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Elapidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Elapidae.Bungarus;

/// <summary>
/// Abstract class for Bungarus (genus).
/// NCBI TaxId: 8612
/// </summary>
public abstract class Bungarus : Elapidae, IBungarus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bungarus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8612;

    /// <inheritdoc />
    public virtual string GenusName => "Bungarus";

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
