using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Eupleridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Eupleridae.Galidia;

/// <summary>
/// Abstract class for Galidia (genus).
/// NCBI TaxId: 61399
/// </summary>
public abstract class Galidia : Eupleridae, IGalidia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Galidia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 61399;

    /// <inheritdoc />
    public virtual string GenusName => "Galidia";

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
