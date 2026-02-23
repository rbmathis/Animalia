using AnimalKingdom.root.Metazoa.Chordata.Aves.Musophagiformes.Musophagidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Musophagiformes.Musophagidae.Gallirex;

/// <summary>
/// Abstract class for Gallirex (genus).
/// NCBI TaxId: 119410
/// </summary>
public abstract class Gallirex : Musophagidae, IGallirex
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gallirex";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 119410;

    /// <inheritdoc />
    public virtual string GenusName => "Gallirex";

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
