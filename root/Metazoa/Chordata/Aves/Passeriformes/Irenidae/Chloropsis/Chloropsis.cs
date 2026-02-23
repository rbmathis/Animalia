using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Irenidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Irenidae.Chloropsis;

/// <summary>
/// Abstract class for Chloropsis (genus).
/// NCBI TaxId: 175116
/// </summary>
public abstract class Chloropsis : Irenidae, IChloropsis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chloropsis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 175116;

    /// <inheritdoc />
    public virtual string GenusName => "Chloropsis";

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
