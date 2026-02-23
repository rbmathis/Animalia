using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Platycephalidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Platycephalidae.Leviprora;

/// <summary>
/// Abstract class for Leviprora (genus).
/// NCBI TaxId: 1230796
/// </summary>
public abstract class Leviprora : Platycephalidae, ILeviprora
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Leviprora";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1230796;

    /// <inheritdoc />
    public virtual string GenusName => "Leviprora";

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
