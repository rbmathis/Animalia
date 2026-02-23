using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Scopelarchidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Scopelarchidae.Lagiacrusichthys;

/// <summary>
/// Abstract class for Lagiacrusichthys (genus).
/// NCBI TaxId: 1622146
/// </summary>
public abstract class Lagiacrusichthys : Scopelarchidae, ILagiacrusichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lagiacrusichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1622146;

    /// <inheritdoc />
    public virtual string GenusName => "Lagiacrusichthys";

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
