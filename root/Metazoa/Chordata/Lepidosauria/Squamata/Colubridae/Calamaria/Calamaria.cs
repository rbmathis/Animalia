using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Calamaria;

/// <summary>
/// Abstract class for Calamaria (genus).
/// NCBI TaxId: 186545
/// </summary>
public abstract class Calamaria : Colubridae, ICalamaria
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Calamaria";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 186545;

    /// <inheritdoc />
    public virtual string GenusName => "Calamaria";

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
