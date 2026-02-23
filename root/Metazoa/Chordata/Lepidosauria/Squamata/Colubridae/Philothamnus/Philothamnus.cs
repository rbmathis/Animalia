using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Philothamnus;

/// <summary>
/// Abstract class for Philothamnus (genus).
/// NCBI TaxId: 186595
/// </summary>
public abstract class Philothamnus : Colubridae, IPhilothamnus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Philothamnus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 186595;

    /// <inheritdoc />
    public virtual string GenusName => "Philothamnus";

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
