using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae.Psilops;

/// <summary>
/// Abstract class for Psilops (genus).
/// NCBI TaxId: 2137177
/// </summary>
public abstract class Psilops : Gymnophthalmidae, IPsilops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Psilops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2137177;

    /// <inheritdoc />
    public virtual string GenusName => "Psilops";

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
