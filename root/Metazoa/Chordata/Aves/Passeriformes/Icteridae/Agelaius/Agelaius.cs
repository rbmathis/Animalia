using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Icteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Icteridae.Agelaius;

/// <summary>
/// Abstract class for Agelaius (genus).
/// NCBI TaxId: 9190
/// </summary>
public abstract class Agelaius : Icteridae, IAgelaius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Agelaius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9190;

    /// <inheritdoc />
    public virtual string GenusName => "Agelaius";

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
