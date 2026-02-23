using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Passerellidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Passerellidae.Spizella;

/// <summary>
/// Abstract class for Spizella (genus).
/// NCBI TaxId: 40206
/// </summary>
public abstract class Spizella : Passerellidae, ISpizella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Spizella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 40206;

    /// <inheritdoc />
    public virtual string GenusName => "Spizella";

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
