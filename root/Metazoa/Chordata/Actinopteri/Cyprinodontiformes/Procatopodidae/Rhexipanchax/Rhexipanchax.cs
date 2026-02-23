using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Procatopodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Procatopodidae.Rhexipanchax;

/// <summary>
/// Abstract class for Rhexipanchax (genus).
/// NCBI TaxId: 2109925
/// </summary>
public abstract class Rhexipanchax : Procatopodidae, IRhexipanchax
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rhexipanchax";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2109925;

    /// <inheritdoc />
    public virtual string GenusName => "Rhexipanchax";

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
