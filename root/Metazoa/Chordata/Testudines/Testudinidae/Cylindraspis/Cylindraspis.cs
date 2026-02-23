using AnimalKingdom.root.Metazoa.Chordata.Testudines.Testudinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Testudinidae.Cylindraspis;

/// <summary>
/// Abstract class for Cylindraspis (genus).
/// NCBI TaxId: 180173
/// </summary>
public abstract class Cylindraspis : Testudinidae, ICylindraspis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cylindraspis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 180173;

    /// <inheritdoc />
    public virtual string GenusName => "Cylindraspis";

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
