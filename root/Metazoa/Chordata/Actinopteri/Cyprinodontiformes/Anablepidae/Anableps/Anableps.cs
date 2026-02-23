using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Anablepidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Anablepidae.Anableps;

/// <summary>
/// Abstract class for Anableps (genus).
/// NCBI TaxId: 143028
/// </summary>
public abstract class Anableps : Anablepidae, IAnableps
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Anableps";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 143028;

    /// <inheritdoc />
    public virtual string GenusName => "Anableps";

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
