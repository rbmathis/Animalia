using AnimalKingdom.root.Metazoa.Chordata.Testudines.Emydidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Emydidae.Clemmys;

/// <summary>
/// Abstract class for Clemmys (genus).
/// NCBI TaxId: 52432
/// </summary>
public abstract class Clemmys : Emydidae, IClemmys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Clemmys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 52432;

    /// <inheritdoc />
    public virtual string GenusName => "Clemmys";

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
