using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Craugastoridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Craugastoridae.Euparkerella;

/// <summary>
/// Abstract class for Euparkerella (genus).
/// NCBI TaxId: 611794
/// </summary>
public abstract class Euparkerella : Craugastoridae, IEuparkerella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Euparkerella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 611794;

    /// <inheritdoc />
    public virtual string GenusName => "Euparkerella";

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
