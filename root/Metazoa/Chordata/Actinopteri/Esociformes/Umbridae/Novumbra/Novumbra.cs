using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Esociformes.Umbridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Esociformes.Umbridae.Novumbra;

/// <summary>
/// Abstract class for Novumbra (genus).
/// NCBI TaxId: 75936
/// </summary>
public abstract class Novumbra : Umbridae, INovumbra
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Novumbra";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 75936;

    /// <inheritdoc />
    public virtual string GenusName => "Novumbra";

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
