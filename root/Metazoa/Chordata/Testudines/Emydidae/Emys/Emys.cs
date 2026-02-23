using AnimalKingdom.root.Metazoa.Chordata.Testudines.Emydidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Emydidae.Emys;

/// <summary>
/// Abstract class for Emys (genus).
/// NCBI TaxId: 82167
/// </summary>
public abstract class Emys : Emydidae, IEmys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Emys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 82167;

    /// <inheritdoc />
    public virtual string GenusName => "Emys";

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
