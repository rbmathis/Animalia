using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sylviidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sylviidae.Urosphena;

/// <summary>
/// Abstract class for Urosphena (genus).
/// NCBI TaxId: 260107
/// </summary>
public abstract class Urosphena : Sylviidae, IUrosphena
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Urosphena";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 260107;

    /// <inheritdoc />
    public virtual string GenusName => "Urosphena";

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
