using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sittidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sittidae.Tichodroma;

/// <summary>
/// Abstract class for Tichodroma (genus).
/// NCBI TaxId: 237441
/// </summary>
public abstract class Tichodroma : Sittidae, ITichodroma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tichodroma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 237441;

    /// <inheritdoc />
    public virtual string GenusName => "Tichodroma";

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
