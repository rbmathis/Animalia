using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Kyphosidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Kyphosidae.Medialuna;

/// <summary>
/// Abstract class for Medialuna (genus).
/// NCBI TaxId: 314242
/// </summary>
public abstract class Medialuna : Kyphosidae, IMedialuna
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Medialuna";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 314242;

    /// <inheritdoc />
    public virtual string GenusName => "Medialuna";

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
