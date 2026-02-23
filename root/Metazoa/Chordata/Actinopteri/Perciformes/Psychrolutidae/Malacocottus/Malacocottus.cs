using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Psychrolutidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Psychrolutidae.Malacocottus;

/// <summary>
/// Abstract class for Malacocottus (genus).
/// NCBI TaxId: 200681
/// </summary>
public abstract class Malacocottus : Psychrolutidae, IMalacocottus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Malacocottus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 200681;

    /// <inheritdoc />
    public virtual string GenusName => "Malacocottus";

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
