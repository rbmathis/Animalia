using AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae.Calypte;

/// <summary>
/// Abstract class for Calypte (genus).
/// NCBI TaxId: 9243
/// </summary>
public abstract class Calypte : Trochilidae, ICalypte
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Calypte";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9243;

    /// <inheritdoc />
    public virtual string GenusName => "Calypte";

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
