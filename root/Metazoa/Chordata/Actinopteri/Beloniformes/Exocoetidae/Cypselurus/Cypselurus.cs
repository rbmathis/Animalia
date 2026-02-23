using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beloniformes.Exocoetidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beloniformes.Exocoetidae.Cypselurus;

/// <summary>
/// Abstract class for Cypselurus (genus).
/// NCBI TaxId: 123222
/// </summary>
public abstract class Cypselurus : Exocoetidae, ICypselurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cypselurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 123222;

    /// <inheritdoc />
    public virtual string GenusName => "Cypselurus";

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
