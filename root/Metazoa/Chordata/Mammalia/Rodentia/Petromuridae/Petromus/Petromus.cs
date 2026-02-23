using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Petromuridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Petromuridae.Petromus;

/// <summary>
/// Abstract class for Petromus (genus).
/// NCBI TaxId: 10182
/// </summary>
public abstract class Petromus : Petromuridae, IPetromus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Petromus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 10182;

    /// <inheritdoc />
    public virtual string GenusName => "Petromus";

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
