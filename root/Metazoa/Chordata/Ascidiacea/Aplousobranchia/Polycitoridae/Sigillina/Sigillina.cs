using AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Aplousobranchia.Polycitoridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Aplousobranchia.Polycitoridae.Sigillina;

/// <summary>
/// Abstract class for Sigillina (genus).
/// NCBI TaxId: 440059
/// </summary>
public abstract class Sigillina : Polycitoridae, ISigillina
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sigillina";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 440059;

    /// <inheritdoc />
    public virtual string GenusName => "Sigillina";

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
