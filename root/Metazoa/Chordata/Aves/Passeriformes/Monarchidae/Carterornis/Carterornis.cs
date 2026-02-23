using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Monarchidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Monarchidae.Carterornis;

/// <summary>
/// Abstract class for Carterornis (genus).
/// NCBI TaxId: 1576518
/// </summary>
public abstract class Carterornis : Monarchidae, ICarterornis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Carterornis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1576518;

    /// <inheritdoc />
    public virtual string GenusName => "Carterornis";

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
