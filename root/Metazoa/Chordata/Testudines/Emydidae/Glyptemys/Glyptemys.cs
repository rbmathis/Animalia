using AnimalKingdom.root.Metazoa.Chordata.Testudines.Emydidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Emydidae.Glyptemys;

/// <summary>
/// Abstract class for Glyptemys (genus).
/// NCBI TaxId: 335391
/// </summary>
public abstract class Glyptemys : Emydidae, IGlyptemys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Glyptemys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 335391;

    /// <inheritdoc />
    public virtual string GenusName => "Glyptemys";

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
