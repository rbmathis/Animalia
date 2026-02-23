using AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Haematopodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Haematopodidae.Haematopus;

/// <summary>
/// Abstract class for Haematopus (genus).
/// NCBI TaxId: 32635
/// </summary>
public abstract class Haematopus : Haematopodidae, IHaematopus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Haematopus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 32635;

    /// <inheritdoc />
    public virtual string GenusName => "Haematopus";

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
