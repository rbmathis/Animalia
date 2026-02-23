using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Atretium;

/// <summary>
/// Abstract class for Atretium (genus).
/// NCBI TaxId: 763647
/// </summary>
public abstract class Atretium : Colubridae, IAtretium
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Atretium";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 763647;

    /// <inheritdoc />
    public virtual string GenusName => "Atretium";

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
