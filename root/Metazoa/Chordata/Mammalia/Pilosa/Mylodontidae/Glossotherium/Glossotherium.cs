using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Pilosa.Mylodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Pilosa.Mylodontidae.Glossotherium;

/// <summary>
/// Abstract class for Glossotherium (genus).
/// NCBI TaxId: 2546653
/// </summary>
public abstract class Glossotherium : Mylodontidae, IGlossotherium
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Glossotherium";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2546653;

    /// <inheritdoc />
    public virtual string GenusName => "Glossotherium";

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
