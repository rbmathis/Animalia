using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Galagidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Galagidae.Paragalago;

/// <summary>
/// Abstract class for Paragalago (genus).
/// NCBI TaxId: 2604441
/// </summary>
public abstract class Paragalago : Galagidae, IParagalago
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Paragalago";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2604441;

    /// <inheritdoc />
    public virtual string GenusName => "Paragalago";

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
