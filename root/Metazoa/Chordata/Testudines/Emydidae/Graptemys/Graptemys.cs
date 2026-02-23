using AnimalKingdom.root.Metazoa.Chordata.Testudines.Emydidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Emydidae.Graptemys;

/// <summary>
/// Abstract class for Graptemys (genus).
/// NCBI TaxId: 8480
/// </summary>
public abstract class Graptemys : Emydidae, IGraptemys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Graptemys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8480;

    /// <inheritdoc />
    public virtual string GenusName => "Graptemys";

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
