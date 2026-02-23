using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Galagidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Galagidae.Galago;

/// <summary>
/// Abstract class for Galago (genus).
/// NCBI TaxId: 9462
/// </summary>
public abstract class Galago : Galagidae, IGalago
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Galago";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9462;

    /// <inheritdoc />
    public virtual string GenusName => "Galago";

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
