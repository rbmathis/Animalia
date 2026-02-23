using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Viperidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Viperidae.Protobothrops;

/// <summary>
/// Abstract class for Protobothrops (genus).
/// NCBI TaxId: 103943
/// </summary>
public abstract class Protobothrops : Viperidae, IProtobothrops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Protobothrops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 103943;

    /// <inheritdoc />
    public virtual string GenusName => "Protobothrops";

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
