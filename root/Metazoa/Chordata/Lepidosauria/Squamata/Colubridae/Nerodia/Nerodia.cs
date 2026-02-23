using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Nerodia;

/// <summary>
/// Abstract class for Nerodia (genus).
/// NCBI TaxId: 8591
/// </summary>
public abstract class Nerodia : Colubridae, INerodia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nerodia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8591;

    /// <inheritdoc />
    public virtual string GenusName => "Nerodia";

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
