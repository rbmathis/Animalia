using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Anablepidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Anablepidae.Oxyzygonectes;

/// <summary>
/// Abstract class for Oxyzygonectes (genus).
/// NCBI TaxId: 143030
/// </summary>
public abstract class Oxyzygonectes : Anablepidae, IOxyzygonectes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Oxyzygonectes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 143030;

    /// <inheritdoc />
    public virtual string GenusName => "Oxyzygonectes";

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
