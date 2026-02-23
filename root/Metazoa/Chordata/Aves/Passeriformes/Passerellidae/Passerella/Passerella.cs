using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Passerellidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Passerellidae.Passerella;

/// <summary>
/// Abstract class for Passerella (genus).
/// NCBI TaxId: 44388
/// </summary>
public abstract class Passerella : Passerellidae, IPasserella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Passerella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 44388;

    /// <inheritdoc />
    public virtual string GenusName => "Passerella";

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
