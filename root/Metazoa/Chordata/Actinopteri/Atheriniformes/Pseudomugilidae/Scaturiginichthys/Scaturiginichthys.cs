using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Pseudomugilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Pseudomugilidae.Scaturiginichthys;

/// <summary>
/// Abstract class for Scaturiginichthys (genus).
/// NCBI TaxId: 1527671
/// </summary>
public abstract class Scaturiginichthys : Pseudomugilidae, IScaturiginichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Scaturiginichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1527671;

    /// <inheritdoc />
    public virtual string GenusName => "Scaturiginichthys";

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
