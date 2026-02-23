using AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae.Lamprolaima;

/// <summary>
/// Abstract class for Lamprolaima (genus).
/// NCBI TaxId: 347503
/// </summary>
public abstract class Lamprolaima : Trochilidae, ILamprolaima
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lamprolaima";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 347503;

    /// <inheritdoc />
    public virtual string GenusName => "Lamprolaima";

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
