using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Meliphagidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Meliphagidae.Grantiella;

/// <summary>
/// Abstract class for Grantiella (genus).
/// NCBI TaxId: 266359
/// </summary>
public abstract class Grantiella : Meliphagidae, IGrantiella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Grantiella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 266359;

    /// <inheritdoc />
    public virtual string GenusName => "Grantiella";

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
