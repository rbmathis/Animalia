using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Zimmerius;

/// <summary>
/// Abstract class for Zimmerius (genus).
/// NCBI TaxId: 456437
/// </summary>
public abstract class Zimmerius : Tyrannidae, IZimmerius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Zimmerius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 456437;

    /// <inheritdoc />
    public virtual string GenusName => "Zimmerius";

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
