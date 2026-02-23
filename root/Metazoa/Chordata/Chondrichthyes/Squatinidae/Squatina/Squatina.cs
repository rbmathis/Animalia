using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Squatinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Squatinidae.Squatina;

/// <summary>
/// Abstract class for Squatina (genus).
/// NCBI TaxId: 55141
/// </summary>
public abstract class Squatina : Squatinidae, ISquatina
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Squatina";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 55141;

    /// <inheritdoc />
    public virtual string GenusName => "Squatina";

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
