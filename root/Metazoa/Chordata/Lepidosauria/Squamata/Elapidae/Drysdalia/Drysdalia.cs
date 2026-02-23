using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Elapidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Elapidae.Drysdalia;

/// <summary>
/// Abstract class for Drysdalia (genus).
/// NCBI TaxId: 66185
/// </summary>
public abstract class Drysdalia : Elapidae, IDrysdalia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Drysdalia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 66185;

    /// <inheritdoc />
    public virtual string GenusName => "Drysdalia";

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
