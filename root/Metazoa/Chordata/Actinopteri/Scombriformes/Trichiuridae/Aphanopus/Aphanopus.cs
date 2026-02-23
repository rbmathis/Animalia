using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Trichiuridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Trichiuridae.Aphanopus;

/// <summary>
/// Abstract class for Aphanopus (genus).
/// NCBI TaxId: 268864
/// </summary>
public abstract class Aphanopus : Trichiuridae, IAphanopus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Aphanopus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 268864;

    /// <inheritdoc />
    public virtual string GenusName => "Aphanopus";

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
