using AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae.Leucochloris;

/// <summary>
/// Abstract class for Leucochloris (genus).
/// NCBI TaxId: 1507469
/// </summary>
public abstract class Leucochloris : Trochilidae, ILeucochloris
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Leucochloris";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1507469;

    /// <inheritdoc />
    public virtual string GenusName => "Leucochloris";

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
