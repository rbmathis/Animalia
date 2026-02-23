using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Stereocyclops;

/// <summary>
/// Abstract class for Stereocyclops (genus).
/// NCBI TaxId: 1240780
/// </summary>
public abstract class Stereocyclops : Microhylidae, IStereocyclops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Stereocyclops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1240780;

    /// <inheritdoc />
    public virtual string GenusName => "Stereocyclops";

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
