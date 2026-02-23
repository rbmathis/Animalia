using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Eupleridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Eupleridae.Galidictis;

/// <summary>
/// Abstract class for Galidictis (genus).
/// NCBI TaxId: 215635
/// </summary>
public abstract class Galidictis : Eupleridae, IGalidictis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Galidictis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 215635;

    /// <inheritdoc />
    public virtual string GenusName => "Galidictis";

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
