using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cotingidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cotingidae.Haematoderus;

/// <summary>
/// Abstract class for Haematoderus (genus).
/// NCBI TaxId: 114304
/// </summary>
public abstract class Haematoderus : Cotingidae, IHaematoderus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Haematoderus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 114304;

    /// <inheritdoc />
    public virtual string GenusName => "Haematoderus";

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
