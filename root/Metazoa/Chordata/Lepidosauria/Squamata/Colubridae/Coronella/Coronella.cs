using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Coronella;

/// <summary>
/// Abstract class for Coronella (genus).
/// NCBI TaxId: 186547
/// </summary>
public abstract class Coronella : Colubridae, ICoronella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Coronella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 186547;

    /// <inheritdoc />
    public virtual string GenusName => "Coronella";

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
