using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Percopsiformes.Aphredoderidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Percopsiformes.Aphredoderidae.Aphredoderus;

/// <summary>
/// Abstract class for Aphredoderus (genus).
/// NCBI TaxId: 94918
/// </summary>
public abstract class Aphredoderus : Aphredoderidae, IAphredoderus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Aphredoderus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 94918;

    /// <inheritdoc />
    public virtual string GenusName => "Aphredoderus";

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
