using AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Aplousobranchia.Polycitoridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Aplousobranchia.Polycitoridae.Polycitorella;

/// <summary>
/// Abstract class for Polycitorella (genus).
/// NCBI TaxId: 440061
/// </summary>
public abstract class Polycitorella : Polycitoridae, IPolycitorella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Polycitorella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 440061;

    /// <inheritdoc />
    public virtual string GenusName => "Polycitorella";

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
