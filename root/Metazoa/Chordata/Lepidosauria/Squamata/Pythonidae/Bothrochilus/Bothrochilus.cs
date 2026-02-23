using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Pythonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Pythonidae.Bothrochilus;

/// <summary>
/// Abstract class for Bothrochilus (genus).
/// NCBI TaxId: 461340
/// </summary>
public abstract class Bothrochilus : Pythonidae, IBothrochilus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bothrochilus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 461340;

    /// <inheritdoc />
    public virtual string GenusName => "Bothrochilus";

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
