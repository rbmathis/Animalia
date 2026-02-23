using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Icteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Icteridae.Dives;

/// <summary>
/// Abstract class for Dives (genus).
/// NCBI TaxId: 84796
/// </summary>
public abstract class Dives : Icteridae, IDives
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dives";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 84796;

    /// <inheritdoc />
    public virtual string GenusName => "Dives";

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
