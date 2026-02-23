using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Pseudelaphe;

/// <summary>
/// Abstract class for Pseudelaphe (genus).
/// NCBI TaxId: 201803
/// </summary>
public abstract class Pseudelaphe : Colubridae, IPseudelaphe
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudelaphe";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 201803;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudelaphe";

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
