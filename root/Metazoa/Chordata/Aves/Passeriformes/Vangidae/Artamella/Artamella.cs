using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Vangidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Vangidae.Artamella;

/// <summary>
/// Abstract class for Artamella (genus).
/// NCBI TaxId: 125312
/// </summary>
public abstract class Artamella : Vangidae, IArtamella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Artamella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 125312;

    /// <inheritdoc />
    public virtual string GenusName => "Artamella";

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
