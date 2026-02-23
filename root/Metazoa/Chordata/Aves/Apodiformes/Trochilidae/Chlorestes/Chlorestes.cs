using AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae.Chlorestes;

/// <summary>
/// Abstract class for Chlorestes (genus).
/// NCBI TaxId: 2744916
/// </summary>
public abstract class Chlorestes : Trochilidae, IChlorestes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chlorestes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2744916;

    /// <inheritdoc />
    public virtual string GenusName => "Chlorestes";

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
