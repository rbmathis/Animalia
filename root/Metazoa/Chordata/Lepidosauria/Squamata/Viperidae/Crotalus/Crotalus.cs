using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Viperidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Viperidae.Crotalus;

/// <summary>
/// Abstract class for Crotalus (genus).
/// NCBI TaxId: 8728
/// </summary>
public abstract class Crotalus : Viperidae, ICrotalus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Crotalus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8728;

    /// <inheritdoc />
    public virtual string GenusName => "Crotalus";

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
