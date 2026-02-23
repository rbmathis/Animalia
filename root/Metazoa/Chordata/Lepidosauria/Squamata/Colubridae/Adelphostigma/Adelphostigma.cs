using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Adelphostigma;

/// <summary>
/// Abstract class for Adelphostigma (genus).
/// NCBI TaxId: 3148919
/// </summary>
public abstract class Adelphostigma : Colubridae, IAdelphostigma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Adelphostigma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3148919;

    /// <inheritdoc />
    public virtual string GenusName => "Adelphostigma";

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
