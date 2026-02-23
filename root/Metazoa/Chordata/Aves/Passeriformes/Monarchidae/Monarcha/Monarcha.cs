using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Monarchidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Monarchidae.Monarcha;

/// <summary>
/// Abstract class for Monarcha (genus).
/// NCBI TaxId: 175125
/// </summary>
public abstract class Monarcha : Monarchidae, IMonarcha
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Monarcha";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 175125;

    /// <inheritdoc />
    public virtual string GenusName => "Monarcha";

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
