using AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae.Pterophanes;

/// <summary>
/// Abstract class for Pterophanes (genus).
/// NCBI TaxId: 304681
/// </summary>
public abstract class Pterophanes : Trochilidae, IPterophanes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pterophanes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 304681;

    /// <inheritdoc />
    public virtual string GenusName => "Pterophanes";

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
