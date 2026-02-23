using AnimalKingdom.root.Metazoa.Chordata.Aves.Falconiformes.Falconidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Falconiformes.Falconidae.Phalcoboenus;

/// <summary>
/// Abstract class for Phalcoboenus (genus).
/// NCBI TaxId: 56344
/// </summary>
public abstract class Phalcoboenus : Falconidae, IPhalcoboenus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Phalcoboenus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 56344;

    /// <inheritdoc />
    public virtual string GenusName => "Phalcoboenus";

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
