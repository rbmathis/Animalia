using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gerreiformes.Gerreidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gerreiformes.Gerreidae.Pentaprion;

/// <summary>
/// Abstract class for Pentaprion (genus).
/// NCBI TaxId: 495038
/// </summary>
public abstract class Pentaprion : Gerreidae, IPentaprion
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pentaprion";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 495038;

    /// <inheritdoc />
    public virtual string GenusName => "Pentaprion";

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
