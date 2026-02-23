using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Nomeidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Nomeidae.Psenes;

/// <summary>
/// Abstract class for Psenes (genus).
/// NCBI TaxId: 316140
/// </summary>
public abstract class Psenes : Nomeidae, IPsenes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Psenes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 316140;

    /// <inheritdoc />
    public virtual string GenusName => "Psenes";

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
