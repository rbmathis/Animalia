using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Rhinocryptidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Rhinocryptidae.Eugralla;

/// <summary>
/// Abstract class for Eugralla (genus).
/// NCBI TaxId: 519480
/// </summary>
public abstract class Eugralla : Rhinocryptidae, IEugralla
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Eugralla";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 519480;

    /// <inheritdoc />
    public virtual string GenusName => "Eugralla";

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
