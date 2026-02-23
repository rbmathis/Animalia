using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Masticophis;

/// <summary>
/// Abstract class for Masticophis (genus).
/// NCBI TaxId: 94898
/// </summary>
public abstract class Masticophis : Colubridae, IMasticophis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Masticophis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 94898;

    /// <inheritdoc />
    public virtual string GenusName => "Masticophis";

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
