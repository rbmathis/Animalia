using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Euclichthyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Euclichthyidae.Euclichthys;

/// <summary>
/// Abstract class for Euclichthys (genus).
/// NCBI TaxId: 630725
/// </summary>
public abstract class Euclichthys : Euclichthyidae, IEuclichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Euclichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 630725;

    /// <inheritdoc />
    public virtual string GenusName => "Euclichthys";

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
