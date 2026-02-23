using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Centrolophidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Centrolophidae.Pseudoicichthys;

/// <summary>
/// Abstract class for Pseudoicichthys (genus).
/// NCBI TaxId: 1091430
/// </summary>
public abstract class Pseudoicichthys : Centrolophidae, IPseudoicichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudoicichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1091430;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudoicichthys";

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
