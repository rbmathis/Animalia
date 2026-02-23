using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Elapidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Elapidae.Pseudonaja;

/// <summary>
/// Abstract class for Pseudonaja (genus).
/// NCBI TaxId: 8672
/// </summary>
public abstract class Pseudonaja : Elapidae, IPseudonaja
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudonaja";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8672;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudonaja";

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
