using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Pteropodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Pteropodidae.Desmalopex;

/// <summary>
/// Abstract class for Desmalopex (genus).
/// NCBI TaxId: 515994
/// </summary>
public abstract class Desmalopex : Pteropodidae, IDesmalopex
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Desmalopex";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 515994;

    /// <inheritdoc />
    public virtual string GenusName => "Desmalopex";

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
