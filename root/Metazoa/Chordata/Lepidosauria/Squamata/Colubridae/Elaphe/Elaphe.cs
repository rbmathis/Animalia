using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Elaphe;

/// <summary>
/// Abstract class for Elaphe (genus).
/// NCBI TaxId: 8579
/// </summary>
public abstract class Elaphe : Colubridae, IElaphe
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Elaphe";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8579;

    /// <inheritdoc />
    public virtual string GenusName => "Elaphe";

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
