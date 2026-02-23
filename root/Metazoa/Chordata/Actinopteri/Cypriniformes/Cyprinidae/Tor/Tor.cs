using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Tor;

/// <summary>
/// Abstract class for Tor (genus).
/// NCBI TaxId: 172918
/// </summary>
public abstract class Tor : Cyprinidae, ITor
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tor";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 172918;

    /// <inheritdoc />
    public virtual string GenusName => "Tor";

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
