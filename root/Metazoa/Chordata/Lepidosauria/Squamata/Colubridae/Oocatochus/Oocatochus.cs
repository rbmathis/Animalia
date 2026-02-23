using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Oocatochus;

/// <summary>
/// Abstract class for Oocatochus (genus).
/// NCBI TaxId: 201784
/// </summary>
public abstract class Oocatochus : Colubridae, IOocatochus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Oocatochus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 201784;

    /// <inheritdoc />
    public virtual string GenusName => "Oocatochus";

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
