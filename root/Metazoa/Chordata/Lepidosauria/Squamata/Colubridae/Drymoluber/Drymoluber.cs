using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Drymoluber;

/// <summary>
/// Abstract class for Drymoluber (genus).
/// NCBI TaxId: 699578
/// </summary>
public abstract class Drymoluber : Colubridae, IDrymoluber
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Drymoluber";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 699578;

    /// <inheritdoc />
    public virtual string GenusName => "Drymoluber";

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
