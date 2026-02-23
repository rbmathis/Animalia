using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Torpediniformes.Narcinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Torpediniformes.Narcinidae.Diplobatis;

/// <summary>
/// Abstract class for Diplobatis (genus).
/// NCBI TaxId: 1870829
/// </summary>
public abstract class Diplobatis : Narcinidae, IDiplobatis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Diplobatis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1870829;

    /// <inheritdoc />
    public virtual string GenusName => "Diplobatis";

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
