using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Corvidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Corvidae.Sphecotheres;

/// <summary>
/// Abstract class for Sphecotheres (genus).
/// NCBI TaxId: 254660
/// </summary>
public abstract class Sphecotheres : Corvidae, ISphecotheres
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sphecotheres";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 254660;

    /// <inheritdoc />
    public virtual string GenusName => "Sphecotheres";

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
