using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Phrynonax;

/// <summary>
/// Abstract class for Phrynonax (genus).
/// NCBI TaxId: 1899477
/// </summary>
public abstract class Phrynonax : Colubridae, IPhrynonax
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Phrynonax";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1899477;

    /// <inheritdoc />
    public virtual string GenusName => "Phrynonax";

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
