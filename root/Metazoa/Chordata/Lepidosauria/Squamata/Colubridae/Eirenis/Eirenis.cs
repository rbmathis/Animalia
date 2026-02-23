using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Eirenis;

/// <summary>
/// Abstract class for Eirenis (genus).
/// NCBI TaxId: 166100
/// </summary>
public abstract class Eirenis : Colubridae, IEirenis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Eirenis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 166100;

    /// <inheritdoc />
    public virtual string GenusName => "Eirenis";

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
