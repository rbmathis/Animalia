using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Psychrolutidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Psychrolutidae.Ambophthalmos;

/// <summary>
/// Abstract class for Ambophthalmos (genus).
/// NCBI TaxId: 2696643
/// </summary>
public abstract class Ambophthalmos : Psychrolutidae, IAmbophthalmos
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ambophthalmos";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2696643;

    /// <inheritdoc />
    public virtual string GenusName => "Ambophthalmos";

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
