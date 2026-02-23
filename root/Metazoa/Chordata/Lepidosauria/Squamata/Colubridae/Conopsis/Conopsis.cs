using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Conopsis;

/// <summary>
/// Abstract class for Conopsis (genus).
/// NCBI TaxId: 1544367
/// </summary>
public abstract class Conopsis : Colubridae, IConopsis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Conopsis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1544367;

    /// <inheritdoc />
    public virtual string GenusName => "Conopsis";

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
