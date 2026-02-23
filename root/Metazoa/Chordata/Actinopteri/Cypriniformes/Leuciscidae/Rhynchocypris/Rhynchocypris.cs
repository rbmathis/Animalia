using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae.Rhynchocypris;

/// <summary>
/// Abstract class for Rhynchocypris (genus).
/// NCBI TaxId: 933989
/// </summary>
public abstract class Rhynchocypris : Leuciscidae, IRhynchocypris
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rhynchocypris";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 933989;

    /// <inheritdoc />
    public virtual string GenusName => "Rhynchocypris";

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
