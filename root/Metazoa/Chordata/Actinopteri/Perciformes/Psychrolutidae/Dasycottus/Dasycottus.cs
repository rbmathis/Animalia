using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Psychrolutidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Psychrolutidae.Dasycottus;

/// <summary>
/// Abstract class for Dasycottus (genus).
/// NCBI TaxId: 274782
/// </summary>
public abstract class Dasycottus : Psychrolutidae, IDasycottus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dasycottus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 274782;

    /// <inheritdoc />
    public virtual string GenusName => "Dasycottus";

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
