using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Mimidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Mimidae.Margarops;

/// <summary>
/// Abstract class for Margarops (genus).
/// NCBI TaxId: 111984
/// </summary>
public abstract class Margarops : Mimidae, IMargarops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Margarops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 111984;

    /// <inheritdoc />
    public virtual string GenusName => "Margarops";

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
