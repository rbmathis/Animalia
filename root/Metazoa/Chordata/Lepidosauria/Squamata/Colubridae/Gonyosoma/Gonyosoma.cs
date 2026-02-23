using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Gonyosoma;

/// <summary>
/// Abstract class for Gonyosoma (genus).
/// NCBI TaxId: 39147
/// </summary>
public abstract class Gonyosoma : Colubridae, IGonyosoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gonyosoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 39147;

    /// <inheritdoc />
    public virtual string GenusName => "Gonyosoma";

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
