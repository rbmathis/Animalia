using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cotingidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cotingidae.Gymnoderus;

/// <summary>
/// Abstract class for Gymnoderus (genus).
/// NCBI TaxId: 114298
/// </summary>
public abstract class Gymnoderus : Cotingidae, IGymnoderus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gymnoderus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 114298;

    /// <inheritdoc />
    public virtual string GenusName => "Gymnoderus";

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
