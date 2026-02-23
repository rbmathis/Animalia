using AnimalKingdom.root.Metazoa.Chordata.Testudines.Chelidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Chelidae.Platemys;

/// <summary>
/// Abstract class for Platemys (genus).
/// NCBI TaxId: 44503
/// </summary>
public abstract class Platemys : Chelidae, IPlatemys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Platemys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 44503;

    /// <inheritdoc />
    public virtual string GenusName => "Platemys";

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
