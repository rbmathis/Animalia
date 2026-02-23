using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Passeridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Passeridae.Gymnoris;

/// <summary>
/// Abstract class for Gymnoris (genus).
/// NCBI TaxId: 1405429
/// </summary>
public abstract class Gymnoris : Passeridae, IGymnoris
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gymnoris";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1405429;

    /// <inheritdoc />
    public virtual string GenusName => "Gymnoris";

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
