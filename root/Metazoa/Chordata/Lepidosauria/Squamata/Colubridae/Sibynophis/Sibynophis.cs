using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Sibynophis;

/// <summary>
/// Abstract class for Sibynophis (genus).
/// NCBI TaxId: 1070322
/// </summary>
public abstract class Sibynophis : Colubridae, ISibynophis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sibynophis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1070322;

    /// <inheritdoc />
    public virtual string GenusName => "Sibynophis";

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
