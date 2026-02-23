using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Meliphagidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Meliphagidae.Sugomel;

/// <summary>
/// Abstract class for Sugomel (genus).
/// NCBI TaxId: 2496571
/// </summary>
public abstract class Sugomel : Meliphagidae, ISugomel
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sugomel";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2496571;

    /// <inheritdoc />
    public virtual string GenusName => "Sugomel";

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
