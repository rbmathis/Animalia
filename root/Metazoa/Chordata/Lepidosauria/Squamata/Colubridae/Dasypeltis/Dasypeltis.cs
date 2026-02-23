using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Dasypeltis;

/// <summary>
/// Abstract class for Dasypeltis (genus).
/// NCBI TaxId: 99588
/// </summary>
public abstract class Dasypeltis : Colubridae, IDasypeltis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dasypeltis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 99588;

    /// <inheritdoc />
    public virtual string GenusName => "Dasypeltis";

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
