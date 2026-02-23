using AnimalKingdom.root.Metazoa.Chordata.Testudines.Emydidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Emydidae.Actinemys;

/// <summary>
/// Abstract class for Actinemys (genus).
/// NCBI TaxId: 335394
/// </summary>
public abstract class Actinemys : Emydidae, IActinemys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Actinemys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 335394;

    /// <inheritdoc />
    public virtual string GenusName => "Actinemys";

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
