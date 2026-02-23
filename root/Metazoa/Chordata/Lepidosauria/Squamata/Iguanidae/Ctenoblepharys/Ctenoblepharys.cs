using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Iguanidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Iguanidae.Ctenoblepharys;

/// <summary>
/// Abstract class for Ctenoblepharys (genus).
/// NCBI TaxId: 167111
/// </summary>
public abstract class Ctenoblepharys : Iguanidae, ICtenoblepharys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ctenoblepharys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 167111;

    /// <inheritdoc />
    public virtual string GenusName => "Ctenoblepharys";

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
