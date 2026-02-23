using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Dicaeidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Dicaeidae.Dicaeum;

/// <summary>
/// Abstract class for Dicaeum (genus).
/// NCBI TaxId: 135426
/// </summary>
public abstract class Dicaeum : Dicaeidae, IDicaeum
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dicaeum";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 135426;

    /// <inheritdoc />
    public virtual string GenusName => "Dicaeum";

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
