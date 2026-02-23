using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Viverridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Viverridae.Diplogale;

/// <summary>
/// Abstract class for Diplogale (genus).
/// NCBI TaxId: 1198221
/// </summary>
public abstract class Diplogale : Viverridae, IDiplogale
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Diplogale";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1198221;

    /// <inheritdoc />
    public virtual string GenusName => "Diplogale";

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
