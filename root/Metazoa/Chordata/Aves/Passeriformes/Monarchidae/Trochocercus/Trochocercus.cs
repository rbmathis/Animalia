using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Monarchidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Monarchidae.Trochocercus;

/// <summary>
/// Abstract class for Trochocercus (genus).
/// NCBI TaxId: 107229
/// </summary>
public abstract class Trochocercus : Monarchidae, ITrochocercus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Trochocercus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 107229;

    /// <inheritdoc />
    public virtual string GenusName => "Trochocercus";

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
