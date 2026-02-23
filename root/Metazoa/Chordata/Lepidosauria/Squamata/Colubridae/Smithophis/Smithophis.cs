using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Smithophis;

/// <summary>
/// Abstract class for Smithophis (genus).
/// NCBI TaxId: 2596748
/// </summary>
public abstract class Smithophis : Colubridae, ISmithophis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Smithophis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2596748;

    /// <inheritdoc />
    public virtual string GenusName => "Smithophis";

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
