using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Dinodon;

/// <summary>
/// Abstract class for Dinodon (genus).
/// NCBI TaxId: 56548
/// </summary>
public abstract class Dinodon : Colubridae, IDinodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dinodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 56548;

    /// <inheritdoc />
    public virtual string GenusName => "Dinodon";

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
